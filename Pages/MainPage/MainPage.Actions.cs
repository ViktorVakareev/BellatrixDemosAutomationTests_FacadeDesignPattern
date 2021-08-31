using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BellatrixDemosAutomationTests_FacadeDesignPattern
{
    public partial class MainPage : BasePage
    {
        private HelperMethods _helperMethods;

        public MainPage(IWebDriver driver) 
            : base(driver)
        {
            _helperMethods = new HelperMethods(driver);
        }

        protected override string Url => "https://demos.bellatrix.solutions/";

        public void AddRocketToShoppingCart(string rocketName)
        {
            //_helperMethods.WaitToExists(ProductBoxByName(rocketName));
            //_helperMethods.WaitForAjax();
            AddToCartByName(rocketName).Click();
            _helperMethods.WaitToExists(ViewCartButtonLocator);
        }

        public void ViewShoppingCart(string rocketName)
        {
            ViewCartButton.Click();
            _helperMethods.WaitForAjax();
        }

        public void ViewShoppingCartIconHover()
        {
            _helperMethods.HoverOverElement(ViewYourShoppingCartIcon);           
        }

        public void ClickViewShoppingCartIcon()
        {
            ViewYourShoppingCartIcon.Click();
        }

        public void OpenRocketInfoPage(string rocketName)
        {            
            ProductBoxByName(rocketName).Click();
            _helperMethods.WaitForAjax();
        }

        public override void WaitForPageLoad()
        {
            _helperMethods.WaitForPageLoad();
        }
    }
}
