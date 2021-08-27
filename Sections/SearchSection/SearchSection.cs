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
        private readonly Driver _driver;

        public SearchSection(Driver driver)
        {
            _driver = driver;
        }

        private Element SearchField => _driver.FindElement(By.Id("woocommerce-product-search-field-0"));

        public void SearchForItem(string searchText)
        {
            SearchField.TypeText(searchText);
        }
    }
}
