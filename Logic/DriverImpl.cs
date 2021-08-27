using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixDemosAutomationTests_FacadeDesignPattern
{
    public class DriverImpl : Driver
    {
        public DriverImpl(Driver driver)
            :base(driver)
        {
        }

        public override Element FindElement(By locator)
        {
            throw new NotImplementedException();
        }

        public override List<Element> FindElements(By locator)
        {
            throw new NotImplementedException();
        }

        public override void GoToUrl(string url)
        {
            throw new NotImplementedException();
        }

        public override void Quit()
        {
            throw new NotImplementedException();
        }

        public override void Start()
        {
            throw new NotImplementedException();
        }

        public override void WaitForAjax()
        {
            throw new NotImplementedException();
        }

        public override void WaitUntilPageLoadsCompletely()
        {
            throw new NotImplementedException();
        }
    }
}
