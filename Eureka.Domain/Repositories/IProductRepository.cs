using Eureka.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Eureka.Domain.Repositories
{
    public interface IProductRepository
    {
        List<Product> Get(int skip, int take);
        Product GetById(Guid id);
        List<Product> GetByCategory(string category);
        List<Product> GetByBrand(string brand);
        List<Product> GetByModel(string model);
        List<Product> GetByName(string name);
        List<Product> GetByPrice(decimal price);
        void Create(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
