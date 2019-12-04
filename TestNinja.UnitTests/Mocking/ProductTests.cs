using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    class ProductTests
    {
        [Test]
        public void GetPrice_IfIsGoldCustomer_30PerceontOff()
        {
            var product = new Product {ListPrice = 100};
            var result = product.GetPrice(new Customer{IsGold = true});
            Assert.That(result, Is.EqualTo(70));
        }

        [Test]
        public void GetPrice_IfIsGoldCustomer_30PerceontOff2()
        {
            var cust = new Mock<ICustomer>();
            cust.Setup(c => c.IsGold).Returns(true);

            var product = new Product { ListPrice = 100 };
            var result = product.GetPrice(cust.Object);
            Assert.That(result, Is.EqualTo(70));
        }
    }
}
