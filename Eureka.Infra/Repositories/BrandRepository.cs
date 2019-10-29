using System;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;
using Eureka.Domain.Entities;
using Eureka.Domain.Repositories;
using Eureka.Infra.Persistence.DataContexts;

namespace Eureka.Infra.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private EurekaDataContext _context;
        public BrandRepository(EurekaDataContext context)
        {
            _context = context;
        }

        public void Create(Brand brand)
        {
            _context.Brands.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _context.Brands.Remove(brand);
        }

        public List<Brand> Get()
        {
            return _context.Brands.ToList();
        }

        public Brand GetById(Guid id)
        {
            return _context.Brands.Find(id);
        }

        public Brand GetByName(string name)
        {
            return _context.Brands.Find(name);
        }

        public void Update(Brand brand)
        {
            _context.Entry<Brand>(brand).State = EntityState.Modified;
        }
    }
}
