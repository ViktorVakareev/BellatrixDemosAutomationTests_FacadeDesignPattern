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
        //// BUG: Cannot remove item from cart through "View yor shopping cart"
        
        //MainPageTests
        [Test]
        public void OpenCorrectRocketInfoPage()
        {
            string rocketName = "Falcon 9";

            _mainPage.Open();
            _mainPage.OpenRocketInfoPage(rocketName);

            _mainPage.AssertCorrectRocketInfoPageOpened(rocketName);
        }

        [Test]
        public void AddCorrectRocketToCart()
        {
            string rocketName = "Proton Rocket";

            _mainPage.Open();
            _mainPage.AddRocketToShoppingCart(rocketName);
            _mainPage.ViewShoppingCart(rocketName);

            _cartPage.AssertCorrectRocketAddedToCart(rocketName);
        }

        [Test]
        public void CorrectSubtotalPrice_WhenOnViewYourShoppingCart()
        {
            string rocketName = "Falcon 9";
            string expectedSubtotalPrice = "50.00€";

            _mainPage.Open();
            _mainPage.AddRocketToShoppingCart(rocketName);
            _mainPage.ViewShoppingCartFieldHover();

            _mainPage.AssertCorrectSubtotalOnViewYourShoppingCart(expectedSubtotalPrice);
        }

        // Search tests
        [Test]
        public void CorrectProductShownOnSearchResultsPage_WhenUsingSearchForExistingProduct()
        {
            string searchName = "Falcon 9";

            _mainPage.Open();
            _searchSection.SearchForItem(searchName);

            _searchSection.AssertCorrectSearchResult(searchName);
        }

        [Test]
        public void NoProductMessageOnSearchResultsPage_WhenUsingSearchForNonExistingProduct()
        {
            string searchName = "Galco 10";

            _mainPage.Open();
            _searchSection.SearchForItem(searchName);

            _searchSection.AssertWrongSearchResult();
        }

        [Test]
        public void PurchaseFalcon9WithoutFacade()
        {
            _mainPage.Open();
            _mainPage.AddRocketToShoppingCart("Falcon 9");
            //_cartPage.ApplyCoupon("happybirthday");
            //_cartPage.Assertions.AssertCouponAppliedSuccessfully();
            //_cartPage.IncreaseProductQuantity(2);
            //_cartPage.Assertions.AssertTotalPrice("114.00€");
            //_cartPage.ClickProceedToCheckout();

            //var credentials = new BillingDetails()
            //{
            //    Email = "silvanio.tiesto@gmail.com",
            //    FirstName = "Silvanio",
            //    LastName = "Tiesto",
            //    Company = "Jimmy",
            //    Country = "Bulgaria",
            //    Address1 = "Sredna gora 66",
            //    Address2 = "Ilinden",
            //    Town = "Sofia",
            //    State = "Sofia-grad",
            //    Zip = "1404",
            //    Phone = "+359885666998",
            //};
            //_checkoutPage.FillBillingInfo(credentials);
            //_checkoutPage.AssertOrderReceived();
        }
    }
}
