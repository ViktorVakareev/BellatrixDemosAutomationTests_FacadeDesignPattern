using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace BellatrixDemosAutomationTests_FacadeDesignPattern
{
    [TestFixture]
    public partial class BellatrixDemosTests
    {
        private IWebDriver _driver;
        private MainPage _mainPage;
        private CartPage _cartPage;
        private CheckoutPage _checkoutPage;
        private Facade _facade;        

        [SetUp]
        public void StartUp()
        {

            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(25);
            _driver.Manage().Window.Maximize();
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
