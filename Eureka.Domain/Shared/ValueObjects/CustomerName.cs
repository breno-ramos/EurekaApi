using Eureka.Domain.Shared.Scopes;

namespace Eureka.Domain.Shared.ValueObjects
{
    public class CustomerName
    {
        public CustomerName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            if (this.ValidFirstName() && this.ValidLastName())
                CompleteName = firstName + " " + lastName;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string CompleteName { get; private set; }
    }
}
