using System;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;
using Eureka.Domain.Entities;
using Eureka.Domain.Repositories;
using Eureka.Infra.Persistence.DataContexts;

namespace Eureka.Infra.Repositories
{
    public class SubscriptionRepository : ISubscriptionRepository
    {
        private EurekaDataContext _context;

        public SubscriptionRepository(EurekaDataContext context)
        {
            _context = context;
        }

        public void Create(Subscription subscription)
        {
            _context.Subscriptions.Add(subscription);
        }

        public void Delete(Subscription subscription)
        {
            _context.Subscriptions.Remove(subscription);
        }

        public List<Subscription> Get()
        {
            return _context.Subscriptions.ToList();
        }
        
        public Subscription GetById(Guid id)
        {
            return _context.Subscriptions.Find(id);
        }

        public void Update(Subscription subscription)
        {
            _context.Entry<Subscription>(subscription).State = EntityState.Modified;
        }
    }
}
