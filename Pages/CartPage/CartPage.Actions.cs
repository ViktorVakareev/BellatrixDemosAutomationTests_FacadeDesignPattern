using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixDemosAutomationTests_FacadeDesignPattern
{
    public partial class CartPage : BasePage
    {
        private HelperMethods _helperMethods;
        public CartPage(IWebDriver driver)
            :base(driver)
        {
            _helperMethods = new HelperMethods(driver);
        }
        protected override string Url => "https://demos.bellatrix.solutions/cart/";

        public override void WaitForPageLoad()
        {
            _helperMethods.WaitForPageLoad();
        }

        public void ClickUpdateCartButton()
        {
            _helperMethods.WaitToBeClickable(UpdateCartButtonLocator);
            UpdateCartButton.Click();
            _helperMethods.WaitForAjax();
        } 
        
        public void RemoveItemByName(string rocketToRemove)
        {
            RemoveItemButtonByName(rocketToRemove).Click();
            _helperMethods.WaitToExists(CartPageTextMessageFieldLocator);
        }

        public void IncreaseQuantityByName(string rocketName, int quantity)
        {
            string quantityText = quantity.ToString();
            _helperMethods.EnterText(quantityText, QuantityByNameField(rocketName));
            _helperMethods.WaitForAjax();
        }
    }
}
