using System;
using System.Collections.Generic;
using Eureka.Domain.Entities;

namespace Eureka.Domain.Repositories
{
    public interface IPlanRepository
    {
        List<Plan> Get();
        Plan GetById(Guid id);
        Plan GetByName(string name);
        void Create(Plan plan);
        void Update(Plan plan);
        void Delete(Plan plan);
    }
}
