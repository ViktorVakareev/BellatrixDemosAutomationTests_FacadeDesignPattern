using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixDemosAutomationTests_FacadeDesignPattern
{
    public partial class MainPage
    {
        public Element ViewCartButton => _driver.FindElement(By.XPath(""));        

        public Element AddToCartByName(string name)
        {
            return _driver.FindElement(By.XPath($"//h2[contains(text(),'{name}')]/following::a[1]"));
        }

        public Element ProductBoxByName(string name)
        {
            return _driver.FindElement(By.XPath($"//h2[contains(text(),'{name}')]"));
        }

        public Element ProductInfoPageByName(string name)
        {
            return _driver.FindElement(By.XPath($"//h1[contains(text(),'{name}')]"));
        }

    }
}
