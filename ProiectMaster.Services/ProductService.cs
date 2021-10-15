using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using ProiectEC.Entities;
using ProiectMaster.Dataaccess.Interfaces;
using ProiectMaster.Models.DTO;
using ProiectMaster.Models.DTO.VM;
using ProiectMaster.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMaster.Services
{
    
    public class ProductService : IProductServices
    {

        private const string imgFolderName = "img";

        private readonly IRepository<Product, int> productRep;
        private readonly IRepository<ProductType, int> productTypeRep;
        private readonly IMapper mapper;
        private readonly IHostingEnvironment hostingEnvironment;

        public ProductService(IRepository<Product, int> productRep, IRepository<ProductType, int> productTypeRep,IMapper mapper, IHostingEnvironment hostingEnvironment)
        {
            this.productRep = productRep;
            this.productTypeRep = productTypeRep;
            this.mapper = mapper;
            this.hostingEnvironment = hostingEnvironment;

        }
        public void AddProduct(ProductVM dto)
        {
            SaveImage(dto);
            var entity = mapper.Map<Product>(dto);
            productRep.Add(entity);
        }

        public void DeleteProduct(int id)
        {
            var entity = productRep.GetInstance(id);
            if (string.IsNullOrWhiteSpace(entity.ImagePath))
            {
                var filePath = Path.Combine(hostingEnvironment.WebRootPath, entity.ImagePath);
                if (File.Exists(filePath))
                    File.Delete(filePath);
            }

            productRep.Delete(entity);
            
        }

        public IEnumerable<ProductVM> GetAllProducts()
        {
            var list = productRep.GetAll();
            return mapper.Map<List<ProductVM>>(list);

        }

        public ProductVM GetProduct(int id)
        {
            var entity = productRep.GetInstance(id);
            return mapper.Map<ProductVM>(entity);

        }

        public List<IdNameDto> GetProductTypes()
        {
            return productTypeRep.GetAll().Select(e=>new IdNameDto(e.Id,e.Name)).ToList();
        }

        public void UpdateProduct(int id, ProductVM dto)
        {
            var entity = productRep.GetInstance(id);
            var oldFileRelativePath = entity.ImagePath;
            if (dto.ProductImage == null)
                dto.ImagePath = oldFileRelativePath;
            else
            {
                if (!string.IsNullOrWhiteSpace(oldFileRelativePath))
                {
                    var oldFileFullPath = Path.Combine(hostingEnvironment.WebRootPath, oldFileRelativePath);
                    if (File.Exists(oldFileFullPath))
                        File.Delete(oldFileFullPath);
                }
                SaveImage(dto);
            }

            mapper.Map(dto, entity);
            productRep.Update(entity);
        }

        private void SaveImage(ProductVM dto)
        {
            if (dto.ProductImage == null)
                return;
            var imgFolderPath = Path.Combine(hostingEnvironment.WebRootPath, imgFolderName);
            if (!Directory.Exists(imgFolderPath))
                Directory.CreateDirectory(imgFolderPath);

            var fileName = Guid.NewGuid() + Path.GetExtension(dto.ProductImage.FileName);
            var imgFullPath = Path.Combine(imgFolderPath, fileName);

            using (var filestream = new FileStream(imgFullPath, FileMode.Create))
                dto.ProductImage.CopyTo(filestream);

            dto.ImagePath = Path.Combine(imgFolderName, fileName);
        }
    }
}
