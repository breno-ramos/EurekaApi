using Eureka.Domain.Commands.AddressCommands;
using Eureka.Domain.Entities;
using System;

namespace Eureka.Domain.Services
{
    public interface IAddressApplicationService
    {
        Address Create(CreateAddressCommand address);
        Address Update(UpdateAddressCommand address);
        Address Delete(Guid id);
    }
}
