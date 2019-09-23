using Eureka.Domain.Entities;
using Eureka.Domain.Scopes;
using Eureka.Domain.Shared.Enums;
using Eureka.Domain.Shared.Scopes;
using Eureka.Domain.Shared.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eureka.Domain.Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        [TestCategory("Customer")]
        public void ShouldCreateCustomer()
        {
            var customerName = new CustomerName("Marllon", "Ramos");
            Assert.AreEqual(true, CustomerNameScope.CustomerNameIsValid(customerName));

            var document = new Document(EDocumentType.CPF, "12240156732");
            Assert.AreEqual(true, DocumentScope.DocumentIsValid(document));

            var customer = new Customer("Eureka", customerName, document, "87marllon@gmail.com", "12345678", "minhaImagem.jpg");
            Assert.AreEqual(true, CustomerScope.CreateCustomerIsValid(customer));
        }

        [TestMethod]
        [TestCategory("Customer")]
        public void ShouldNotCreateCustomerWithoutCustomerName()
        {
            var customerName = new CustomerName("", "");
            Assert.AreEqual(false, CustomerNameScope.CustomerNameIsValid(customerName));

            var document = new Document(EDocumentType.CPF, "12240156732");
            Assert.AreEqual(true, DocumentScope.DocumentIsValid(document));

            var customer = new Customer("Eureka", customerName, document, "87marllon@gmail.com", "12345678", "minhaImagem.jpg");
            Assert.AreEqual(true, CustomerScope.CreateCustomerIsValid(customer));
        }

        [TestMethod]
        [TestCategory("Customer")]
        public void ShouldNotCreateCustomerWithoutDocument()
        {
            var customerName = new CustomerName("Marllon", "Ramos");
            Assert.AreEqual(true, CustomerNameScope.CustomerNameIsValid(customerName));

            var document = new Document(EDocumentType.CPF, "");
            Assert.AreEqual(false, DocumentScope.DocumentIsValid(document));

            var customer = new Customer("Eureka", customerName, document, "87marllon@gmail.com", "12345678", "minhaImagem.jpg");
            Assert.AreEqual(true, CustomerScope.CreateCustomerIsValid(customer));
        }

        [TestMethod]
        [TestCategory("Customer")]
        public void ShouldNotCreateCustomerWhenDocumentIsInvalid()
        {
            var customerName = new CustomerName("Marllon", "Ramos");
            Assert.AreEqual(true, CustomerNameScope.CustomerNameIsValid(customerName));

            var document = new Document(EDocumentType.CPF, "12233399987");
            Assert.AreEqual(false, DocumentScope.DocumentIsValid(document));

            var customer = new Customer("Eureka", customerName, document, "87marllon@gmail.com", "12345678", "minhaImagem.jpg");
            Assert.AreEqual(true, CustomerScope.CreateCustomerIsValid(customer));
        }
    }
}
