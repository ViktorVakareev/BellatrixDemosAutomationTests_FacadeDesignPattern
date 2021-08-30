using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixDemosAutomationTests_FacadeDesignPattern
{
    public partial class CartPage
    {
        public IWebElement ProductNameField => _driver.FindElement(By.XPath("//td[@class='product-name']"));
    }
}
