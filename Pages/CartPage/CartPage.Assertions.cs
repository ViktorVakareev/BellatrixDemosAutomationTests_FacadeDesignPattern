using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixDemosAutomationTests_FacadeDesignPattern
{
    public partial class CartPage
    {
        public void AssertCorrectRocketAddedToCart(string expectedRocketName)
        {
            string actualRocketName = ProductNameField.Text;
            Assert.AreEqual(expectedRocketName, actualRocketName);
        }

        public void AssertCorrectTotalPriceOnCartPage()
        {
            double expectedTotalPrice = 4500180.00;
            double actualTotalPrice = CalculateTotalPrice();

            Assert.AreEqual(expectedTotalPrice, actualTotalPrice);
        }

        private double CalculateTotalPrice()
        {
            return Double.Parse(SubtotalPriceTextField.Text.Replace("€", "").Replace(",", ""))
                + Double.Parse(VatTextField.Text.Replace("€", "").Replace(",", ""));
        }
    }
}
