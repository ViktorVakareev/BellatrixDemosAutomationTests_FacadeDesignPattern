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

        public Element AddToCartFalcon9 => _driver.FindElement(By.XPath(""));

        public Element GetAddToCartByName(string name)
        {
            return _driver.FindElement(By.XPath($"//h2[contains(text(),'{name}')]/following::a[1]"));
        }

        public Element GetProductBoxByName(string name)
        {
            return _driver.FindElement(By.XPath($"//h2[contains(text(),'{name}')]"));
        }

    }
}
