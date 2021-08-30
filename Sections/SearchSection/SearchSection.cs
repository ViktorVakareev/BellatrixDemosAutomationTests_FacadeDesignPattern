using NUnit.Framework;
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

        private IWebElement SearchPageTopResult => _driver.FindElement(By.XPath("(//h2)[1]"));

        public void SearchForItem(string searchText)
        {
            _helperMethods.EnterText(searchText, SearchField);
            SearchField.SendKeys(Keys.Enter);
        }

        public void AssertCorrectSearchResult(string searchedRocketName)
        {
            string actualSearchPageHeading = SearchPageHeading.Text.Substring(0, 15);
            string actualSearchResult = SearchPageTopResult.Text;

            Assert.AreEqual("Search results:", actualSearchPageHeading);
            Assert.AreEqual(searchedRocketName, actualSearchResult);
        }

        public void AssertWrongSearchResult()
        {
            string actualSearchPageHeading = SearchPageHeading.Text.Substring(0, 15);
            string actualSearchResult = SearchPageNoProductsErrorMessage.Text;

            Assert.AreEqual("Search results:", actualSearchPageHeading);
            Assert.AreEqual("No products were found matching your selection.", actualSearchResult);
        }
    }
}
