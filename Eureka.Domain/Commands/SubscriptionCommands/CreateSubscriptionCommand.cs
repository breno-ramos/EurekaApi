using Eureka.Domain.Shared.Enums;

namespace Eureka.Domain.Commands.SubscriptionCommands
{
    public class CreateSubscriptionCommand
    {
        public ESubscriptionType Type { get; set; }
        public int CustomerId { get; set; }
        public int PlanId { get; set; }
    }
}
