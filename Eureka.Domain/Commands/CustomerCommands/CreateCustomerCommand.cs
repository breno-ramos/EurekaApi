using Eureka.Domain.Shared.Enums;

namespace Eureka.Domain.Commands.CustomerCommands
{
    public class CreateCustomerCommand
    {
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EDocumentType DocumentType { get; set; }
        public string DocumentValue { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Logo { get; set; }
    }
}
