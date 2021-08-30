using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixDemosAutomationTests_FacadeDesignPattern
{
    public class SearchSection
    {
        private readonly IWebDriver _driver;
        private HelperMethods _helperMethods;

        public SearchSection(IWebDriver driver)
        {
            _driver = driver;
            _helperMethods = new HelperMethods(driver);
        }

        private IWebElement SearchField => _driver.FindElement(By.XPath("(//input[@type='search'])[1]"));

        private IWebElement SearchPageHeading => _driver.FindElement(By.XPath("//h1"));

        private IWebElement SearchPageNoProductsErrorMessage => _driver.FindElement(By.XPath("//p[@class='woocommerce-info']"));

        private IWebElement SearchPageFirstResult => _driver.FindElement(By.XPath("(//h2)[1]"));

        public void SearchForItem(string searchText)
        {
            _helperMethods.EnterText(searchText, SearchField);
            SearchField.SendKeys(Keys.Enter);
        }
    }
}
