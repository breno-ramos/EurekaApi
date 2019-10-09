using Eureka.Domain.Commands.ProductCommands;
using Eureka.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Eureka.Domain.Services
{
    public interface IProductApplicationService
    {
        List<Product> Get(int skip, int take);
        Product GetById(Guid id);
        List<Product> GetByCategory(string category);
        List<Product> GetByBrand(string brand);
        List<Product> GetByModel(string model);
        List<Product> GetByName(string name);
        List<Product> GetByPrice(decimal price);
        void Create(CreateProductCommands product);
        void Update(UpdateProductCommands product);
        void Delete(Guid id);
    }
}
