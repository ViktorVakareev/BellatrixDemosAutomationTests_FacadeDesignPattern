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
        public IWebElement ViewCartButton => _driver.FindElement(By.XPath("//a[@title='View cart']")); 
        
        public By ViewCartButtonLocator => By.XPath("//a[@title='View cart']");  

        public IWebElement ViewYourShoppingCartIcon => _driver.FindElement(By.XPath("//a[@class='cart-contents']"));  
        
        public IWebElement SubtotalViewShoppingCartField => _driver.FindElement(By.XPath("//strong[contains(text(),'Subtotal')]/following::bdi[1]"));
        
        public By SubtotalViewShoppingCartFieldLocator => By.XPath("//strong[contains(text(),'Subtotal')]/following::bdi[1]");        

        public IWebElement AddToCartByName(string name)
        {
            return _driver.FindElement(By.XPath($"//h2[contains(text(),'{name}')]/following::a[1]"));
        }

        public IWebElement ProductBoxByName(string name)
        {
            return _driver.FindElement(By.XPath($"//h2[contains(text(),'{name}')]"));
        }

        public IWebElement ProductInfoPageByName(string name)
        {
            return _driver.FindElement(By.XPath($"//h1[contains(text(),'{name}')]"));
        }

    }
}
