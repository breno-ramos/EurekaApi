using System;
using System.Collections.Generic;
using Eureka.Domain.Entities;
using Eureka.Domain.Commands.PlanCommands;

namespace Eureka.Domain.Services
{
    public interface IPlanApplicationService
    {
        List<Plan> Get();
        Plan GetById(Guid id);
        Plan GetByName(string name);
        Plan Create(CreatePlanCommand plan);
        Plan Update(UpdatePlanCommand plan);
        Plan Delete(Guid id);
    }
}
