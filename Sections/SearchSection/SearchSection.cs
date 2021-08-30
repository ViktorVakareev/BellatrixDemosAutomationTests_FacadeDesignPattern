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

        public SearchSection(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement SearchField => _driver.FindElement(By.Id("woocommerce-product-search-field-0"));

        public void SearchForItem(string searchText)
        {
            // SearchField.TypeText(searchText);  
        }
    }
}
