using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixDemosAutomationTests_FacadeDesignPattern
{
    [TestFixture]
    public partial class BellatrixDemosTests
    {
        private Driver _driver;
        private MainPage _mainPage;
        private CartPage _cartPage;
        private CheckoutPage _checkoutPage;
        private Facade _facade;        

        [SetUp]
        public void StartUp()
        {

            //_driver = new DriverImpl(new WebDriver());            
            _mainPage = new MainPage(_driver);
            _cartPage = new CartPage(_driver);
            _checkoutPage = new CheckoutPage(_driver);
            _facade = new Facade(_mainPage, _cartPage, _checkoutPage);
        }

        [TearDown]
        public void CloseUp()
        {
            _driver.Quit();
        }
    }
}
