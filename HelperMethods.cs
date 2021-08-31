using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BellatrixDemosAutomationTests_FacadeDesignPattern
{

    public class HelperMethods : BasePage
    {
        private IWebElement _webElement;
        private WebDriverWait _webDriverWait;
        private Actions _actions;

        protected override string Url => "https://demos.bellatrix.solutions/";

        public HelperMethods(IWebDriver driver) : base(driver)
        {
            _webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            _actions = new Actions(driver);
        }

        public void TypeText(string text)
        {
            Thread.Sleep(500);
            _webElement?.Clear();
            _webElement?.SendKeys(text);
        }

        public void WaitToExist(By by)
        {
            _webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(by));
        }

        public void HoverOverElement(IWebElement element)
        {
            _actions.MoveToElement(element).Perform();
        }

        public void WaitToBeClickable(By by)
        {            
            _webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(by));
        }

        public void WaitForAjax()
        {
            var js = (IJavaScriptExecutor)_driver;
            _webDriverWait.Until(wd => js.ExecuteScript("return jQuery.active").ToString() == "0");
        }

        public override void WaitForPageLoad()
        {
            var js = (IJavaScriptExecutor)_driver;
            _webDriverWait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }             

        public void EnterText(string text, IWebElement element)
        {
            Thread.Sleep(500);
            element.Clear();
            element.SendKeys(text);
        }

        public static string GenerateNewRandomEmailOrPassword()
        {
            var rnd = new Random();
            return $"vic{rnd.Next(555, 55555)}@gmail.com";
        }
    }
}
