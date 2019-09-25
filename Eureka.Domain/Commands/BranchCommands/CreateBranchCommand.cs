namespace Eureka.Domain.Commands.BranchCommands
{
    public class CreateBranchCommand
    {
        public CreateBranchCommand(string description)
        {
            Description = description;
        }

        public string Description { get; set; }
    }
}
