using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eureka.Domain.Entities;
using Eureka.Domain.Shared.Enums;
using Eureka.Domain.Shared.ValueObjects;
using Eureka.Domain.Shared.Scopes;
using Eureka.Domain.Scopes;

namespace Eureka.Domain.Tests
{
    [TestClass]
    public class SubscriptionTests
    {
        [TestMethod]
        [TestCategory("Subscription")]
        public void ShouldCreateSubscription()
        {
            var customerName = new CustomerName("Marllon", "Ramos");
            Assert.AreEqual(true, CustomerNameScope.CustomerNameIsValid(customerName));

            var document = new Document(EDocumentType.CPF, "12240156732");
            Assert.AreEqual(true, DocumentScope.DocumentIsValid(document));

            var customer = new Customer("Eureka", customerName, document, "87marllon@gmail.com", "12345678", "minhaImagem.jpg");
            Assert.AreEqual(true, CustomerScope.CustomerIsValid(customer));

            var plan = new Plan("Gold", "Plano muito bom da conta", 20);
            Assert.AreEqual(true, PlanScope.ValidDescription(plan));
            Assert.AreEqual(true, PlanScope.ValidName(plan));
            Assert.AreEqual(true, PlanScope.ValidPrice(plan));            
        } 

        [TestMethod]
        [TestCategory("Subscription")]
        public void ShouldNotCreateSubscriptionWhenCustomerIsInvalid()
        {
            var customerName = new CustomerName("Marllon", "");
            Assert.AreEqual(false, CustomerNameScope.CustomerNameIsValid(customerName));

            var document = new Document(EDocumentType.CPF, "");
            Assert.AreEqual(false, DocumentScope.DocumentIsValid(document));

            var customer = new Customer("Eureka", customerName, document, "87marllon@gmail.com", "", "minhaImagem.jpg");
            Assert.AreEqual(false, CustomerScope.CustomerIsValid(customer));

            var plan = new Plan("Gold", "Plano muito bom da conta", 20);
            Assert.AreEqual(true, PlanScope.ValidDescription(plan));
            Assert.AreEqual(true, PlanScope.ValidName(plan));
            Assert.AreEqual(true, PlanScope.ValidPrice(plan));
        }

        [TestMethod]
        [TestCategory("Subscription")]
        public void ShouldNotCreateSubscriptionWhenPlanIsInvalid()
        {
            var customerName = new CustomerName("Marllon", "Ramos");
            Assert.AreEqual(true, CustomerNameScope.CustomerNameIsValid(customerName));

            var document = new Document(EDocumentType.CPF, "12240156732");
            Assert.AreEqual(true, DocumentScope.DocumentIsValid(document));

            var customer = new Customer("Eureka", customerName, document, "87marllon@gmail.com", "12345678", "minhaImagem.jpg");
            Assert.AreEqual(true, CustomerScope.CustomerIsValid(customer));

            var plan = new Plan("", "Plano muito bom da conta", 20);
            Assert.AreEqual(false, PlanScope.ValidName(plan));
            Assert.AreEqual(true, PlanScope.ValidDescription(plan));
            Assert.AreEqual(true, PlanScope.ValidPrice(plan));
        }
    }
}
