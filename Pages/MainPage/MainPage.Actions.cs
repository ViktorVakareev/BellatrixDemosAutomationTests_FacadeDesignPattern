using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixDemosAutomationTests_FacadeDesignPattern
{
    public partial class MainPage : BasePage
    {
        public MainPage(Driver driver) 
            : base(driver)
        {
        }

        protected override string Url => "https://demos.bellatrix.solutions/";

        public void AddRocketToShoppingCart(string rocketName)
        {
            Open();
            AddToCartByName(rocketName).Click();
            _driver.WaitForAjax();
            ViewCartButton.Click();
        }

        public void OpenRocketInfoPage(string rocketName)
        {
            Open();
            ProductBoxByName(rocketName).Click();
            _driver.WaitForAjax();            
        }

        protected override void WaitForPageLoad()
        {
            //TODO
        }
    }
}
