using System;



namespace LayeredArchitecture.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("deneme");
            IProductService productService = new ProductManager(new EfProductDal());

            foreach (var product in productService.GetAll())
            {
                Console.WriteLine(product.Name);
            }

            Console.ReadKey();
        }
    }
}
