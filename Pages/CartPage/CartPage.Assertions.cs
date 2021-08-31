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

        public void AssertWrongCouponCodeMessage(string couponCode)
        {
            string expectedMessage = $"Coupon \"{couponCode}\" does not exist!";

            Assert.AreEqual(expectedMessage, CartPageErrorMessageField.Text);
        }

        public void AssertEmptyCouponCodeMessage()
        {
            string expectedMessage = "Please enter a coupon code.";

            Assert.AreEqual(expectedMessage, CartPageErrorMessageField.Text);
        }
        
        public void AssertValidCouponCodeMessage()
        {
            string expectedMessage = "Coupon code applied successfully.";

            Assert.AreEqual(expectedMessage, CartPageTextMessageField.Text);
        }

        public void AssertValidCouponDiscount(string expectedDiscount)
        {
            string actualDiscount = CouponDiscountTextField.Text.Substring(1,5);

            Assert.AreEqual(expectedDiscount, actualDiscount);
        }

        private double CalculateTotalPrice()
        {
            return Double.Parse(SubtotalPriceTextField.Text.Replace("€", "").Replace(",", ""))
                + Double.Parse(VatTextField.Text.Replace("€", "").Replace(",", ""));
        }
    }
}
