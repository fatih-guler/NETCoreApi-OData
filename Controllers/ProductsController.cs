using System.Collections.Generic;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using OData_NETCoreApi.Models;
namespace OData_NETCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // Ürün listesi
         private List<Product> _products = new List<Product>(){
             new Product{Type = "Televizyon", Brand = "Apple", Model = 2019, Price = 4999, Name = "Apple Smart TV", StockAmount = 500 },
             new Product{Type = "Telefon", Brand = "LG", Model = 2016, Price = 999, Name = "LG G3 64 GB ", StockAmount = 50 },
             new Product{Type = "Akıllı Saat", Brand = "Xiomi", Model = 2017, Price = 2499, Name = "Xiomi Mi Band 3", StockAmount = 15 },
             new Product{Type = "Telefon", Brand = "Samsung", Model = 2019, Price = 14999, Name = "Samsung Galaxy 10 Plust Elite Diamon", StockAmount = 5 }
         };


        // ## Api üzerinde yapılabilecek sorgular
        //  api/product/getproducts
        // api/product/getproducts?$select=name     
        //  api/product/getproducts?$select=name, price
        // api/product/getproducts?select=name,price&$orderby=price
         [HttpGet]
         // Startup  Configure metodunda belirtilen sorguların yapılabilmesi için sorguları etkinleştirdik
         [EnableQuery()]
         [Route("getproducts")]
         public IEnumerable<Product> GetProducts()
         {
             return this._products;
         }
    }
}