using System;
using System.Collections.Generic;
using Eureka.Domain.Entities;

namespace Eureka.Domain.Repositories
{
    public interface IModelRepository
    {
        List<Model> GetModelByBrandId(Guid id);
        void Create(Model model);
        void Update(Model model);
        void Delete(Model model);
    }
}
