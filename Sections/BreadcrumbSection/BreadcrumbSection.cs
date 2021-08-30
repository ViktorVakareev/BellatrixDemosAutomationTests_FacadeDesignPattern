using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixDemosAutomationTests_FacadeDesignPattern
{
    public class BreadcrumbSection
    {
        private readonly IWebDriver _driver;

        public BreadcrumbSection(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement Breadcrumb => _driver.FindElement(By.ClassName("woocommerce-breadcrumb"));

        public void OpenBreadcrumbItem(string itemToOpen)
        {
            Breadcrumb.FindElement(By.LinkText(itemToOpen)).Click();
        }
    }
}
