using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eureka.Domain.Entities;
using Eureka.Domain.Scopes;

namespace Eureka.Domain.Tests
{
    [TestClass]
    public class BrandTests
    {
        [TestMethod]
        [TestCategory("Brand")]
        public void ShouldCreateBrand()
        { 
            var brand = new Brand("QuickSilver");
            Assert.AreEqual(true, BrandScope.ValidName(brand));            
        }

        [TestMethod]
        [TestCategory("Brand")]
        public void ShouldNotCreateBrandWhenNameIsNull()
        {
            var brand = new Brand("");
            Assert.AreEqual(false, BrandScope.ValidName(brand));
        }

        [TestMethod]
        [TestCategory("Brand")]
        public void ShouldNotCreateBrandWhenNameCharactersLongerThanLimit()
        {
            var brand = new Brand("Nome da marca é superior ao limite permitido permitido");
            Assert.AreEqual(false, BrandScope.ValidName(brand));
        }

        [TestMethod]
        [TestCategory("Brand")]
        public void ShouldNotCreateTagWhenNameIsLessThanLimit()

        {
            var brand = new Brand("N");
            Assert.AreEqual(false, BrandScope.ValidName(brand));
        }
    }
}


