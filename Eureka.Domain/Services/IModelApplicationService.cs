using System;
using System.Collections.Generic;
using Eureka.Domain.Entities;
using Eureka.Domain.Commands.ModelCommands;

namespace Eureka.Domain.Services
{
    public interface IModelApplicationService
    {
        List<Model> GetModelByBrandId(Guid id);
        Model Create(CreateModelCommand model);
        Model Update(UpdateModelCommand model);
        Model Delete(Guid id);
    }
}
