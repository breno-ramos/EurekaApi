using System;
using System.Collections.Generic;
using Eureka.Domain.Commands.BrandCommands;
using Eureka.Domain.Entities;

namespace Eureka.Domain.Services
{
    public interface IBrandApplicationService
    {
        List<Brand> Get();
        Brand GetById(Guid id);
        Brand GetByName(string name);
        Brand Create(CreateBrandCommand command);
        Brand Update(UpdateBrandCommand command);
        Brand Delete(Guid id);
    }
}
