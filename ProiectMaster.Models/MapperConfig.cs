using AutoMapper;
using ProiectEC.Entities;
using ProiectMaster.Models.DTO.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMaster.Models
{
    public static class MapperConfig
    {
        public static IMapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
              {
                  cfg.CreateMap<ProductType, ProductTypeVM>();
                  cfg.CreateMap<ProductTypeVM, ProductType>();

                  cfg.CreateMap<Product, ProductVM>();
                  cfg.CreateMap<ProductVM, Product>();

              });
            return config.CreateMapper();
        }
    }
}
