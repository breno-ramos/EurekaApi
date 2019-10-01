using Eureka.Domain.Entities;
using Eureka.Domain.Scopes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eureka.Domain.Tests
{
    [TestClass]
    public class AddressTests
    {
        [TestMethod]
        [TestCategory("Address")]
        public void ShouldCreateAddress()
        {
            var address = new Address(3060, "Rua Mentor Couto", "Engenho Pequeno", "São Gonçalo", "RJ", "BR");
            Assert.AreEqual(true, AddressScope.AddressValid(address));
        }

        [TestMethod]
        [TestCategory("Address")]
        public void ShouldNotCreateAddressWhenInvalidNumber()
        {
            var address = new Address(-10, "Rua Mentor Couto", "Engenho Pequeno", "São Gonçalo", "RJ", "BR");
            Assert.AreEqual(false, AddressScope.AddressValid(address));
        }

        [TestMethod]
        [TestCategory("Address")]
        public void ShouldNotCreateAddressWhenInvalidStreet()
        {
            var address = new Address(3060, "", "Engenho Pequeno", "São Gonçalo", "RJ", "BR");
            Assert.AreEqual(false, AddressScope.AddressValid(address));
        }

        [TestMethod]
        [TestCategory("Address")]
        public void ShouldNotCreateAddressWhenInvalidNeighborhood()
        {
            var address = new Address(3060, "Rua Mentor Couto", "", "São Gonçalo", "RJ", "BR");
            Assert.AreEqual(false, AddressScope.AddressValid(address));
        }

        [TestMethod]
        [TestCategory("Address")]
        public void ShouldNotCreateAddressWhenInvalidCity()
        {
            var address = new Address(3060, "Rua Mentor Couto", "Engenho Pequeno", "", "RJ", "BR");
            Assert.AreEqual(false, AddressScope.AddressValid(address));
        }

        [TestMethod]
        [TestCategory("Address")]
        public void ShouldNotCreateAddressWhenInvalidState()
        {
            var address = new Address(3060, "Rua Mentor Couto", "Engenho Pequeno", "São Gonçalo", "", "BR");
            Assert.AreEqual(false, AddressScope.AddressValid(address));
        }

        [TestMethod]
        [TestCategory("Address")]
        public void ShouldNotCreateAddressWhenInvalidCountry()
        {
            var address = new Address(3060, "Rua Mentor Couto", "Engenho Pequeno", "São Gonçalo", "RJ", "");
            Assert.AreEqual(false, AddressScope.AddressValid(address));
        }
    }
}
