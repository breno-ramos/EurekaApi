using Eureka.Domain.Entities;
using System.Collections.Generic;

namespace Eureka.Domain.Repositories
{
    public interface IBranchRepository
    {
        List<Branch> Get();
        void Create(Branch branch);
        void Update(Branch branch);
        void Delete(Branch branch);
    }
}
