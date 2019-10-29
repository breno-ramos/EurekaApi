using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Eureka.Domain.Entities;
using Eureka.Domain.Repositories;
using Eureka.Infra.Persistence.DataContexts;

namespace Eureka.Infra.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private EurekaDataContext _context;

        public CategoryRepository(EurekaDataContext context)
        {
            _context = context;
        }

        public void Create(Category category)
        {
            _context.Categories.Add(category);
        }

        public void Delete(Category category)
        {
            _context.Categories.Remove(category);
        }

        public List<Category> Get()
        {
            return _context.Categories.ToList();
        }

        public Category GetById(Guid id)
        {
            return _context.Categories.Find(id);
        }

        public Category GetByName(string name)
        {
            return _context.Categories.Find(name);
        }

        public void Update(Category category)
        {
            _context.Entry<Category>(category).State = EntityState.Modified;
        }
    }
}
