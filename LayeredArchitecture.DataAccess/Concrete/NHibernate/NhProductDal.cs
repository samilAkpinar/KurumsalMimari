using LayeredArchitecture.DataAccess.Abstract;
using LayeredArchitecture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            return new List<Product>
            {
                new Product{Id = 1, Name = "TV"}
            };
        }
    }
}
