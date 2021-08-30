using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixDemosAutomationTests_FacadeDesignPattern
{
    public abstract class BasePage
    {
        protected readonly IWebDriver _driver;

        protected BasePage(IWebDriver driver)
        {
            _driver = driver;
            //SearchSection = new SearchSection(driver);
            //MainMenuSection = new MainMenuSection(driver);
            //CartInfoSection = new CartInfoSection(driver);
        }

        //public SearchSection SearchSection { get; }
        //public MainMenuSection MainMenuSection { get; }
        //public CartInfoSection CartInfoSection { get; }
        protected abstract string Url { get; }

        public void Open()
        {
           _driver.Navigate().GoToUrl(Url);
            WaitForPageLoad();
        }

        public abstract void WaitForPageLoad();
    }
}

