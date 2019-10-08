using Eureka.Domain.Entities;
using Eureka.Domain.Scopes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eureka.Domain.Tests
{
    [TestClass]
    public class ServiceTests
    {
        [TestMethod]
        [TestCategory("Service")]
        public void ShouldCreateService()
        {
            var service = new Service(
                "Salão de Beleza Belo Corte",
                "021991138347",
                "O melhor salão de beleza da região. Fazemos todos os tipos de corte. Trabalhamos com pintura e coloração"
            );
            Assert.AreEqual(true, ServiceScope.ServiceValid(service));
        }

        [TestMethod]
        [TestCategory("Service")]
        public void ShouldNotCreateServiceWhenPhoneLessThan12()
        {
            var service = new Service(
                "Salão de Beleza Belo Corte",
                "991138347",
                "O melhor salão de beleza da região. Fazemos todos os tipos de corte. Trabalhamos com pintura e coloração"
            );
            Assert.AreEqual(false, ServiceScope.ServiceValid(service));
        }

        [TestMethod]
        [TestCategory("Service")]
        public void ShoulNotCreateServiceWithoutPhone()
        {
            var service = new Service(
                "Salão de Beleza Belo Corte",
                "",
                "O melhor salão de beleza da região. Fazemos todos os tipos de corte. Trabalhamos com pintura e coloração"
            );
            Assert.AreEqual(false, ServiceScope.ServiceValid(service));
        }

        [TestMethod]
        [TestCategory("Service")]
        public void ShouldNotCreateServiceWithoutTitle()
        {
            var service = new Service(
                "",
                "021991138347",
                "O melhor salão de beleza da região. Fazemos todos os tipos de corte. Trabalhamos com pintura e coloração"
            );
            Assert.AreEqual(false, ServiceScope.ServiceValid(service));
        }

        [TestMethod]
        [TestCategory("Service")]
        public void ShouldNotCreateServiceWhenTitleMoreThan30()
        {
            var service = new Service(
                "Salão de Beleza Belo Corte Salão de Beleza Belo Corte Salão de Beleza Belo Corte Salão de Beleza Belo Corte Salão de Beleza Belo Corte Salão de Beleza Belo Corte",
                "021991138347",
                "O melhor salão de beleza da região. Fazemos todos os tipos de corte. Trabalhamos com pintura e coloração"
            );
            Assert.AreEqual(false, ServiceScope.ServiceValid(service));
        }

        [TestMethod]
        [TestCategory("Service")]
        public void ShouldNotCreateServiceWhenTitleLessThan3()
        {
            var service = new Service(
                "ab",
                "021991138347",
                "O melhor salão de beleza da região. Fazemos todos os tipos de corte. Trabalhamos com pintura e coloração"
            );
            Assert.AreEqual(false, ServiceScope.ServiceValid(service));
        }

        [TestMethod]
        [TestCategory("Service")]
        public void ShouldNotCreateServiceWithoutDescription()
        {
            var service = new Service(
                "Salão de Beleza Belo Corte",
                "021991138347",
                ""
            );
            Assert.AreEqual(false, ServiceScope.ServiceValid(service));
        }

        [TestMethod]
        [TestCategory("Service")]
        public void ShouldNotCreateServiceWhenDescriptionLessThan10()
        {
            var service = new Service(
                "ab",
                "021991138347",
                "O melhor"
            );
            Assert.AreEqual(false, ServiceScope.ServiceValid(service));
        }
    }
}
