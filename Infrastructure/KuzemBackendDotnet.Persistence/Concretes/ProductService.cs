using KuzemBackendDotnet.Application.Exceptions;
using KuzemBackendDotnet.Domain;
using KuzemBackendDotnet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KuzemBackendDotnet.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            return new() { 
                new Product
                {
                    Id = Guid.NewGuid(),    
                    Name = "prod1",
                    Price = 50,
                    Stock = 20
                }
            };
        }
    }
}
