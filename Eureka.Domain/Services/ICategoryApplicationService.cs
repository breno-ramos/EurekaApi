using System;
using System.Collections.Generic;
using Eureka.Domain.Commands.CategoryCommands;
using Eureka.Domain.Entities;

namespace Eureka.Domain.Services
{
    public interface ICategoryApplicationService
    {
        List<Category> Get();
        Category GetById(Guid id);
        Category GetByName(string name);
        Category Create(CreateCategoryCommand category);
        Category Update(UpdateCategoryCommand category);
        Category Delete(Guid id);
    }
}
