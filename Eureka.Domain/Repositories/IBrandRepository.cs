using System;
using System.Collections.Generic;
using Eureka.Domain.Entities;

namespace Eureka.Domain.Repositories
{
    public interface IBrandRepository
    {
        List<Brand> Get();
        Brand GetById(Guid id);
        Brand GetByName(string name);
        void Create(Brand brand);
        void Update(Brand brand);
        void Delete(Brand brand);
    }
}
