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
            GetProductBoxByName(rocketName).Click();
            _driver.WaitForAjax();
            ViewCartButton.Click();
        }

        public void OpenRocketInfoPage(string rocketName)
        {
            Open();
            GetProductBoxByName(rocketName).Click();
            _driver.WaitForAjax();
            ViewCartButton.Click();
        }

        protected override void WaitForPageLoad()
        {
            //TODO
        }
    }
}
