using Eureka.Domain.Entities;
using Eureka.Domain.Scopes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eureka.Domain.Tests
{
    [TestClass]
    public class PlanTests
    {
        [TestMethod]
        [TestCategory("Plan")]
        public void ShouldCreatePlan()
        {
            var plan = new Plan("Gold", "Plano bom demais da conta", 20000);
            Assert.AreEqual(true, plan.ValidName());
            Assert.AreEqual(true, plan.ValidDescription());            
            Assert.AreEqual(true, plan.ValidPrice());
        }

        [TestMethod]
        [TestCategory("Plan")]
        public void ShouldNotCreatePlanWhenPriceEqualsZero()
        {
            var plan = new Plan("Gold", "Plano bom demais da conta", 0);           
            Assert.AreEqual(false, PlanScope.ValidPrice(plan));
        }

        [TestMethod]
        [TestCategory("Plan")]
        public void ShouldNotCreatePlanWhenNameEqualsEmpty()
        {
            var plan = new Plan("", "Plano bom demais da conta", 2000);
            Assert.AreEqual(false, plan.ValidName());
        }

        [TestMethod]
        [TestCategory("Plan")]
        public void ShoulNotCreatePlanWhenDescriptionEqualsEmpty()
        {
            var plan = new Plan("Gold", "", 2000);
            Assert.AreEqual(false, plan.ValidDescription());
        }
    }
}
