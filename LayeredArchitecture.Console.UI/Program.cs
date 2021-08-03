
using LayeredArchitecture.Business.Abstract;
using LayeredArchitecture.DataAccess.Concrete.EntityFramework;
using System;

namespace LayeredArchitecture.Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ioc Container ile geliştirilir.
            //hata oldu.
            IProductService productService = new ProductManager(new EfProductDal);
        }
    }
}
