using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixDemosAutomationTests_FacadeDesignPattern
{
    public class MainMenuSection
    {
        private readonly IWebDriver _driver;

        public MainMenuSection(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement HomeLink => _driver.FindElement(By.LinkText("Home"));
        private IWebElement BlogLink => _driver.FindElement(By.LinkText("Blog"));
        private IWebElement CartLink => _driver.FindElement(By.LinkText("Cart"));
        private IWebElement CheckoutLink => _driver.FindElement(By.LinkText("Checkout"));
        private IWebElement MyAccountLink => _driver.FindElement(By.LinkText("My Account"));
        private IWebElement PromotionsLink => _driver.FindElement(By.LinkText("Promotions"));

        public void OpenHomePage()
        {
            HomeLink.Click();
        }

        public void OpenBlogPage()
        {
            BlogLink.Click();
        }

        public void OpenMyAccountPage()
        {
            MyAccountLink.Click();
        }

        public void OpenPromotionsPage()
        {
            PromotionsLink.Click();
        }
    }
}

