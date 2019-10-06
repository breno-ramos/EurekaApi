using System;
using System.Collections.Generic;
using Eureka.Domain.Commands.SubscriptionCommands;
using Eureka.Domain.Entities;

namespace Eureka.Domain.Services
{
    public interface ISubscriptionApplicationService
    {
        List<Subscription> Get();
        Subscription GetByCustomer(Guid customerId);
        Subscription GetById(Guid id);        
        Subscription Create(CreateSubscriptionCommand command);
        Subscription Update(UpdateSubscriptionCommand command);
        Subscription Delete(Guid id);
    }
}
