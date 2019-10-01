using System;
using System.Collections.Generic;
using Eureka.Domain.Entities;

namespace Eureka.Domain.Repositories
{
    public interface ICategoryRepository
    {
        List<Category> Get();
        Category GetById(Guid id);
        Category GetByName(string name);
        void Create(Category category);
        void Update(Category category);
        void Delete(Category category);
    }
}
