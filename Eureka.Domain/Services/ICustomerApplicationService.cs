using Eureka.Domain.Commands.CustomerCommands;
using Eureka.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Eureka.Domain.Services
{
    public interface ICustomerApplicationService
    {
        List<Customer> Get(int skip, int take);
        Customer GetById(Guid id);
        Customer GetByEmail(string email);
        Customer Create(CreateCustomerCommand customer);
        Customer Update(UpdateCustomerCommand customer);
        Customer Delete(Guid id);
        Customer Authenticate(string email, string password);
    }
}
