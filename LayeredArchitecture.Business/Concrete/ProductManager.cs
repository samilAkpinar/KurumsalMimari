using Core.Aspects.Logging;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Logging;
using LayeredArchitecture.Business.Abstract;
using LayeredArchitecture.DataAccess.Abstract;
using LayeredArchitecture.DataAccess.Concrete.EntityFramework;
using LayeredArchitecture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.Business.Concrete
{
    public class ProductManager: IProductService
    {
        private IProductDal _productDal;
        
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
            
        }

        [LogAspect]
        public List<Product> GetAll()
        {
            
            return _productDal.GetAll();    
        }
    }
}
