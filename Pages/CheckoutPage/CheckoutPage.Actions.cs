using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixDemosAutomationTests_FacadeDesignPattern
{
    public partial class CheckoutPage : BasePage
    {
        HelperMethods _helperMethods;

        public CheckoutPage(IWebDriver driver) : base(driver)
        {
            _helperMethods = new HelperMethods(driver);
        }

        protected override string Url => "https://demos.bellatrix.solutions/checkout/";

        public override void WaitForPageLoad()
        {
            _helperMethods.WaitForPageLoad();
        }

        public void ClickPlaceOrder()
        {
            PlaceOrderButton.Click();
        }
    }
}
