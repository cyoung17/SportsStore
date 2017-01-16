using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Repository
{
    public class Production : IProductRepository
    {
        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                {
                    new Product { Name = "Football", Price = 25 },
                    new Product { Name = "Baseball", Price = 35 },
                    new Product { Name = "Soccer", Price = 45 }
                };
            }
        }
    }
}
