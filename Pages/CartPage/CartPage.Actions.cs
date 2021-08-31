﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixDemosAutomationTests_FacadeDesignPattern
{
    public partial class CartPage : BasePage
    {
        private HelperMethods _helperMethods;
        public CartPage(IWebDriver driver)
            :base(driver)
        {
            _helperMethods = new HelperMethods(driver);
        }
        protected override string Url => "https://demos.bellatrix.solutions/cart/";

        public override void WaitForPageLoad()
        {
            _helperMethods.WaitForPageLoad();
        }
    }
}
