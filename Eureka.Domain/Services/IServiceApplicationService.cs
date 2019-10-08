using Eureka.Domain.Commands.ServiceCommands;
using Eureka.Domain.Entities;
using System;

namespace Eureka.Domain.Services
{
    public interface IServiceApplicationService
    {
        Service Create(CreateServiceCommand command);
        Service Update(UpdateServiceCommand command);
        Service Delete(Guid id);
    }
}
