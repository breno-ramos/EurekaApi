using Eureka.Domain.Entities;
using Eureka.Domain.Scopes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eureka.Domain.Tests
{
    [TestClass]
    public class BranchTests
    {
        [TestMethod]
        [TestCategory("Branch")]
        public void ShouldCreateBranch()
        {
            var branch = new Branch("Saúde e Beleza");
            Assert.AreEqual(true, BranchScope.BranchValid(branch));
        }

        [TestMethod]
        [TestCategory("Branch")]
        public void ShouldNotCreateBranchWhenInvalidDescription()
        {
            var branch = new Branch("ab");
            Assert.AreEqual(false, BranchScope.BranchValid(branch));
        }

        [TestMethod]
        [TestCategory("Branch")]
        public void ShouldNotCreateBranchWhenDescriptionIsEmpty()
        {
            var branch = new Branch("");
            Assert.AreEqual(false, BranchScope.BranchValid(branch));
        }
    }
}
