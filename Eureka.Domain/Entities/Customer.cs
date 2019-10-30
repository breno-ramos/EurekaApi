using Eureka.Domain.Shared.Entities;
using Eureka.Domain.Shared.Enums;
using Eureka.Domain.Shared.ValueObjects;
using Eureka.Domain.Scopes;

namespace Eureka.Domain.Entities
{
    public class Customer : Entity
    {
        public Customer(string companyName, CustomerName customerName, Document document, string email, 
            string password, string logo, Branch branch, Subscription subscription, Address address)
        {
            CompanyName = companyName;
            CustomerName = customerName;
            Document = document;
            Email = email;
            Password = password;
            Logo = logo;
            Status = EStatusType.Active;
            Branch = branch;
            Subscription = subscription;
            Address = address;

            this.ValidCompanyName();
            this.ValidEmail();
            this.ValidPassword();
            this.ValidLogo();
        }

        public string CompanyName { get; private set; }
        public CustomerName CustomerName { get; private set; }
        public Document Document { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Logo { get; private set; }
        public EStatusType Status { get; private set; }
        public Branch Branch { get; private set; }
        public Subscription Subscription { get; private set; }
        public Address Address { get; private set; }
    }
}
