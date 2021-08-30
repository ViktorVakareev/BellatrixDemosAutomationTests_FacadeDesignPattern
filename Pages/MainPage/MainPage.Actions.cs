using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            AddToCartByName(rocketName).Click();
            //_driver.WaitForAjax();             
        }

        public void ViewShoppingCart(string rocketName)
        {
            ViewCartButton.Click();
            //_driver.WaitForAjax();             
        }

        public void ViewShoppingCartFieldHover()
        {
           _helperMethods.HoverOverElement(ViewYourShoppingCartField);           
        }

        public void OpenRocketInfoPage(string rocketName)
        {            
            ProductBoxByName(rocketName).Click();
           // _driver.WaitForAjax();            
        }

        public override void WaitForPageLoad()
        {
            _helperMethods.WaitForPageLoad();
        }
    }
}
