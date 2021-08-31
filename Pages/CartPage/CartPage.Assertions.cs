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
            string actualRocketName = ProductNameField(expectedRocketName).Text;
            Assert.AreEqual(expectedRocketName, actualRocketName);
        }

        public void AssertCorrectTotalPriceOnCartPage(double expectedTotal)
        {
            double actualTotalPrice = CalculateTotalPrice();

            Assert.AreEqual(expectedTotal, actualTotalPrice);
        }
        
        public void AssertCorrectEmptyCartMessage()
        {
            string expectedMessage = "Your cart is currently empty.";

            Assert.AreEqual(expectedMessage, EmptyCartMessageField.Text);
        }

        public void AssertRemovingCorrectProduct(string rocketToRemove, double expectedTotal)
        {            
            double actualTotalPrice = CalculateTotalPrice();

            Assert.AreEqual($"“{rocketToRemove}” removed. Undo?",CartPageTextMessageField.Text);
            Assert.AreEqual(expectedTotal, actualTotalPrice);
        }

        public void AssertIncreasingQuantityAndUpdateCartButtonWorking(double expectedTotal)
        {
            double actualTotalPrice = CalculateTotalPrice();

            Assert.AreEqual("Cart updated.", CartPageTextMessageField.Text);
            Assert.AreEqual(expectedTotal, actualTotalPrice);
        }

        private double CalculateTotalPrice()
        {
            return Double.Parse(SubtotalPriceTextField.Text.Replace("€", "").Replace(",", ""))
                + Double.Parse(VatTextField.Text.Replace("€", "").Replace(",", ""));
        }
    }
}
