using LayeredArchitecture.Business.Abstract;
using LayeredArchitecture.Business.Concrete;
using LayeredArchitecture.DataAccess.Concrete.EntityFramework;
using LayeredArchitecture.DataAccess.Concrete.NHibernate;
using LayeredArchitecture.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPİ.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        [HttpGet]
        public List<Product> GetAll()
        {
            //Ioc sistemi burada yazılır.
            IProductService productService = new ProductManager(new NhProductDal());
            
            return productService.GetAll();
        }
    }
}
