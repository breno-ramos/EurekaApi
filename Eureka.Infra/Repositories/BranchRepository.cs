using System.Collections.Generic;
using Eureka.Domain.Entities;
using Eureka.Domain.Repositories;
using Eureka.Infra.Persistence.DataContexts;
using System.Data.Entity;
using System.Linq;

namespace Eureka.Infra.Repositories
{
    public class BranchRepository : IBranchRepository
    {
        private EurekaDataContext _context;

        public BranchRepository(EurekaDataContext context)
        {
            _context = context;
        }

        public void Create(Branch branch)
        {
            _context.Branches.Add(branch);
        }

        public void Delete(Branch branch)
        {
            _context.Branches.Remove(branch);
        }

        public void Update(Branch branch)
        {
            _context.Entry<Branch>(branch).State = EntityState.Modified;
        }

        public List<Branch> Get()
        {
            return _context.Branches.ToList();
        }
    }
}
