using Eureka.Domain.Scopes;
using Eureka.Domain.Shared.Entities;

namespace Eureka.Domain.Entities
{
    public class Address : Entity
    {
        public Address(int number, string street, string neighborhood, string city, string state, string country)
        {
            Number = number;
            Street = street;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Country = country;
            Complement = string.Empty;

            this.ValidNumber();
            this.ValidStreet();
            this.ValidNeighborhood();
            this.ValidCity();
            this.ValidState();
            this.ValidCountry();
        }

        public int Number { get; private set; }
        public string Street { get; private set; }
        public string Neighborhood { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string Complement { get; private set; }

        public void RegisterComplement(string complement)
        {
            if (complement != string.Empty)
                this.Complement = complement;
        }
    }
}
