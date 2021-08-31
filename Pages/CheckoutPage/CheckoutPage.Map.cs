using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixDemosAutomationTests_FacadeDesignPattern
{
    public partial class CheckoutPage
    {
        public IWebElement PlaceOrderButton => _driver.FindElement(By.Id("place_order"));

        public IWebElement MissingRequiredFieldsMessage(string missingField)
        {
            return _driver.FindElement(By.XPath($"//ul[@class='woocommerce-error']/li/strong[contains(text(),'{missingField}')]"));
        }    
    }
}
