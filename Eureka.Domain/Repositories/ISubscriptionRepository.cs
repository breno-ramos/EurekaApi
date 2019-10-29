using System;
using System.Collections.Generic;
using Eureka.Domain.Entities;

namespace Eureka.Domain.Repositories
{
    public interface ISubscriptionRepository
    {
        List<Subscription> Get();
        Subscription GetById(Guid id);
        void Create(Subscription subscription);
        void Update(Subscription subscription);
        void Delete(Subscription subscription);
    }
}
