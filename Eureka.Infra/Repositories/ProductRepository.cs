using System;
using System.Linq;
using System.Collections.Generic;
using Eureka.Domain.Entities;
using Eureka.Domain.Repositories;
using Eureka.Infra.Persistence.DataContexts;
using System.Data.Entity;

namespace Eureka.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private EurekaDataContext _context;

        public ProductRepository(EurekaDataContext context)
        {
            _context = context;
        }

        public void Create(Product product)
        {
            _context.Products.Add(product);
        }

        public void Delete(Product product)
        {
            _context.Products.Remove(product);
        }

        public void Update(Product product)
        {
            _context.Entry<Product>(product).State = EntityState.Modified;
        }

        public List<Product> Get(int skip, int take)
        {
            return _context.Products.OrderBy(x => x.Id).Skip(skip).Take(take).ToList();
        }

        public List<Product> GetByBrand(string brand)
        {
            return _context.Products.Where(x => x.Brand.Name == brand).OrderBy(x => x.Id).ToList();
        }

        public List<Product> GetByCategory(string category)
        {
            // TODO
            //return _context.Products.Where(x => x.Categories.Where(x => x.Name == category).OrderBy(x => x.Id).ToList());
            return new List<Product>();
        }

        public Product GetById(Guid id)
        {
            return _context.Products.FirstOrDefault(x => x.Id == id);
        }

        public List<Product> GetByModel(string model)
        {
            return _context.Products.Where(x => x.Model.Nome == model).OrderBy(x => x.Id).ToList();
        }

        public List<Product> GetByName(string name)
        {
            return _context.Products.Where(x => x.Name == name).OrderBy(x => x.Name).ToList();
        }

        public List<Product> GetByPrice(decimal price)
        {
            return _context.Products.Where(x => x.Price == price).OrderBy(x => x.Price).ToList();
        }
    }
}
