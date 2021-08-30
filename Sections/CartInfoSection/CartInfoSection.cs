using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixDemosAutomationTests_FacadeDesignPattern
{
    public class CartInfoSection
    {
        private readonly IWebDriver _driver;

        public CartInfoSection(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement CartIcon => _driver.FindElement(By.ClassName("cart-contents"));
        private IWebElement CartAmount => _driver.FindElement(By.ClassName("amount"));

        public string GetCurrentAmount()
        {
            return CartAmount.Text;
        }

        public void OpenCart()
        {
            CartIcon.Click();
        }
    }
}
