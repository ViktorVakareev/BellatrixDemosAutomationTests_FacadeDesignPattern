using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixDemosAutomationTests_FacadeDesignPattern
{
    public class DriverImpl : DriverDecorator
    {
        public DriverImpl(Driver driver) 
            : base(driver)
        {
        }

        public override Element FindElement(By locator)
        {
            return base.FindElement(locator);
        }

        public override List<Element> FindElements(By locator)
        {
            return base.FindElements(locator);
        }

        public override void GoToUrl(string url)
        {
            base.GoToUrl(url);
        }

        public override void Quit()
        {
            base.Quit();
        }

        public override void Start()
        {
            base.Start();
        }

        public override void WaitForAjax()
        {
            base.WaitForAjax();
        }

        public override void WaitUntilPageLoadsCompletely()
        {
            base.WaitUntilPageLoadsCompletely();
        }
    }
}
