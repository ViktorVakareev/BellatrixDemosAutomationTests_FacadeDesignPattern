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
        public IWebElement CouponTextField => _driver.FindElement(By.XPath("//input[@id='coupon_code']"));

        public IWebElement ApplyCouponButton => _driver.FindElement(By.XPath("//button[@name='apply_coupon']"));

        public IWebElement QuantityTextBox => _driver.FindElement(By.XPath("//input[@type='number']"));

        public IWebElement UpdateCartButton => _driver.FindElement(By.XPath("//button[@name='update_cart']"));

        public By UpdateCartButtonLocator => By.XPath("//button[@name='update_cart']");

        public IWebElement ProceedToCheckoutLink => _driver.FindElement(By.XPath("//a[contains(text(),'checkout')]"));

        public IWebElement TotalPriceTextField => _driver.FindElement(By.XPath("//div[@class='wc-proceed-to-checkout']/preceding::bdi[1]"));

        public IWebElement VatTextField => _driver.FindElement(By.XPath("//div[@class='wc-proceed-to-checkout']/preceding::bdi[2]"));

        public IWebElement SubtotalPriceTextField => _driver.FindElement(By.XPath("//div[@class='wc-proceed-to-checkout']/preceding::bdi[3]"));

        public IWebElement CartPageTextMessageField => _driver.FindElement(By.XPath("//div[@class='woocommerce-message']"));     
        
        public By CartPageTextMessageFieldLocator => By.XPath("//div[@class='woocommerce-message']");       

        public IWebElement ProductNameField(string rocketName)
        {
            return _driver.FindElement(By.XPath($"//a[text()='{rocketName}']"));
        }
        
        public IWebElement QuantityByNameField(string rocketName)
        {
           return _driver.FindElement(By.XPath($"//label[text()='{rocketName} quantity']/following::input[1]"));
        }

        public IWebElement RemoveItemButtonByName(string rocketName)
        {
            return _driver.FindElement(By.XPath($"//td[@class='product-name']/following::a[text()='{rocketName}']/preceding::a[@class='remove'][1]"));
        }
    }
}
