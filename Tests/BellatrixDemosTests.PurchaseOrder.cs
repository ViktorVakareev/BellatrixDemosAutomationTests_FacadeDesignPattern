using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixDemosAutomationTests_FacadeDesignPattern
{
    public partial class BellatrixDemosTests
    {
        [Test]
        public void PurchaseFalcon9WithoutFacade()
        {
            _mainPage.Open();
            _mainPage.AddRocketToShoppingCart("Falcon 9");
            _cartPage.ApplyCoupon("happybirthday");
            _cartPage.Assertions.AssertCouponAppliedSuccessfully();
            _cartPage.IncreaseProductQuantity(2);
            _cartPage.Assertions.AssertTotalPrice("114.00€");
            _cartPage.ClickProceedToCheckout();

            var credentials = new BillingDetails()
            {
                Email = "silvanio.tiesto@gmail.com",
                FirstName = "Silvanio",
                LastName = "Tiesto",
                Company = "Jimmy",
                Country = "Bulgaria",
                Address1 = "Sredna gora 66",
                Address2 = "Ilinden",
                Town = "Sofia",
                State = "Sofia-grad",
                Zip = "1404",
                Phone = "+359885666998",
            };
            _checkoutPage.FillBillingInfo(credentials);
            _checkoutPage.AssertOrderReceived();
        }
    }
}
