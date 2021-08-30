using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixDemosAutomationTests_FacadeDesignPattern
{
    public partial class MainPage
    {
        public void AssertCorrectRocketInfoPageOpened(string expectedRocketName) {
            string actualRocketName = ProductInfoPageByName(expectedRocketName).Text;
            Assert.AreEqual(actualRocketName,expectedRocketName);
        }

        public void AssertCorrectSubtotalOnViewYourShoppingCart(string expectedSubtotalPrice)
        {
            string actualSubtotalPrice = SubtotalViewShoppingCartField.Text;
            Assert.AreEqual(actualSubtotalPrice, expectedSubtotalPrice);
        }
    }
}
