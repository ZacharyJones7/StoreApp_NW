using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
    public class FakeProductRepository : IProductRepository
    { 
       public IQueryable<Product> Products => new List<Product>
        {
            new Product{Name="Jonesy's Signiture Football", Price = 10000000 },
            new Product{Name="Jonesy's Ego", Price = 100 },
            new Product{Name="Peanuts", Price = 100 },
        }.AsQueryable<Product>();
    }
}
