namespace Eureka.Domain.Commands.PlanCommands
{
    public class UpdatePlanCommand
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
