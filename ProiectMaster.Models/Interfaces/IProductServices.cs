

using ProiectMaster.Models.DTO;
using ProiectMaster.Models.DTO.VM;
using System.Collections.Generic;

namespace ProiectMaster.Models.Interfaces
{
    public interface IProductServices
    {
        IEnumerable<ProductVM> GetAllProducts();
        ProductVM GetProduct(int id);
        void AddProduct(ProductVM dto);
        void UpdateProduct(int id, ProductVM dto);
        void DeleteProduct(int id);

        List<IdNameDto> GetProductTypes();
    }
}
