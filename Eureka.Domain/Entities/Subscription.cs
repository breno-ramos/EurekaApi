using System;
using Eureka.Domain.Shared.Entities;
using Eureka.Domain.Shared.Enums;

namespace Eureka.Domain.Entities
{
    public class Subscription : Entity
    {
        public Subscription(ESubscriptionType type, Plan plan)
        {
            Type = type;
            Plan = plan;
            CreateIn = DateTime.Now;
            ExpiresIn = DateTime.Now.AddYears(1);
            Status = EStatusType.Active;
        }

        public DateTime CreateIn { get; private set; }
        public DateTime ExpiresIn { get; private set; }
        public EStatusType Status { get; private set; }
        public ESubscriptionType Type { get; private set; }    
        public Plan Plan { get; private set; }
    }
}
