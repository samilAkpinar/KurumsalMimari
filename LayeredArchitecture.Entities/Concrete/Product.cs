using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.Entities.Concrete
{

    //IEntity -> bir veritabanı nesnesidir anlamındadır.
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
