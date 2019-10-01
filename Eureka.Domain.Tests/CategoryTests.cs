using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eureka.Domain.Entities;
using Eureka.Domain.Scopes;

namespace Eureka.Domain.Tests
{
    [TestClass]
    public class CategoryTests
    {
        [TestMethod]
        [TestCategory("Category")]
        public void ShouldCreateCategory()
        {
            var category = new Category("Esportes");
            Assert.AreEqual(true, CategoryScope.ValidName(category));
        }

        [TestMethod]
        [TestCategory("Category")]
        public void ShouldNotCreateCategoryWithoutName()
        {
            var category = new Category("");
            Assert.AreEqual(false, CategoryScope.ValidName(category));
        }
    }
}
