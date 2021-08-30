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

        public IWebElement CouponTextField => _driver.FindElement(By.XPath("//input[@id='coupon_code']"));

        public IWebElement ApplyCouponButton => _driver.FindElement(By.XPath("//button[@name='apply_coupon']"));

        public IWebElement QuantityTextBox => _driver.FindElement(By.XPath("//input[@type='number']"));

        public IWebElement UpdateCartButton => _driver.FindElement(By.XPath("//button[@name='update_cart']"));

        public IWebElement ProceedToCheckoutLink => _driver.FindElement(By.XPath("//a[contains(text(),'checkout')]"));

        public IWebElement TotalPriceTextFieldBeforeCheckout => _driver.FindElement(By.XPath("//div[@class='wc-proceed-to-checkout']/preceding::bdi[1]"));
    }
}
