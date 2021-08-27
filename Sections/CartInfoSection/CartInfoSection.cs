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
        private readonly Driver _driver;

        public CartInfoSection(Driver driver)
        {
            _driver = driver;
        }

        private Element CartIcon => _driver.FindElement(By.ClassName("cart-contents"));
        private Element CartAmount => _driver.FindElement(By.ClassName("amount"));

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
