using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Eureka.Domain.Entities;
using Eureka.Domain.Repositories;
using Eureka.Infra.Persistence.DataContexts;

namespace Eureka.Infra.Repositories
{
    public class PlanRepository : IPlanRepository
    {
        private EurekaDataContext _context;

        public PlanRepository(EurekaDataContext context)
        {
            _context = context;
        }

        public void Create(Plan plan)
        {
            _context.Plans.Add(plan);
        }

        public void Delete(Plan plan)
        {
            _context.Plans.Remove(plan);
        }

        public List<Plan> Get()
        {
            return _context.Plans.ToList();
        }

        public Plan GetById(Guid id)
        {
            return _context.Plans.Find(id);
        }

        public Plan GetByName(string name)
        {
            return _context.Plans.Find(name);
        }

        public void Update(Plan plan)
        {
            _context.Entry<Plan>(plan).State = EntityState.Modified;
        }
    }
}
