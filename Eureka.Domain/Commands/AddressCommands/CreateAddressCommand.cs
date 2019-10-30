using System;

namespace Eureka.Domain.Commands.AddressCommands
{
    public class CreateAddressCommand
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public string Street { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Complement { get; set; }
    }
}
