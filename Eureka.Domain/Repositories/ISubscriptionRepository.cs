using System;
using System.Collections.Generic;
using Eureka.Domain.Entities;

namespace Eureka.Domain.Repositories
{
    public interface ISubscriptionRepository
    {
        List<Subscription> Get();
        Subscription GetById(Guid id);
        Subscription GetByCustomer(Guid customerId);
        void Create(Subscription subscription);
        void Update(Subscription subscription);
        void Delete(Guid id);
    }
}
