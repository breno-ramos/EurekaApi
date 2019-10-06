using System;
using Eureka.Domain.Shared.Enums;

namespace Eureka.Domain.Commands.SubscriptionCommands
{
    public class UpdateSubscriptionCommand
    {
        public ESubscriptionType Type { get; set; }
        public Guid CustomerId { get; set; }
    }
}
