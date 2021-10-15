using Microsoft.AspNetCore.Mvc;
using ProiectMaster.Models.DTO.VM;
using ProiectMaster.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectEC.Controllers
{
    [Route("[Controller]")]
    public class ShoppingCartController : Controller
    {

        private readonly IProductServices productServices;

        public ShoppingCartController(IProductServices productServices)
        {
            this.productServices = productServices;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var shopList = HttpContext.Session.Get<List<int>>(SessionHelper.ShoppingCart);
            var products = new List<ProductVM>();

            if (shopList != null)
            {
                foreach (var item in shopList)
                {
                    var dto = productServices.GetProduct(item);
                    if (dto != null)
                    {
                        products.Add(dto);
                    }
                }
            }

            return View(products);
        }
    }
}
