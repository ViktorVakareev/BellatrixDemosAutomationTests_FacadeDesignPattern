using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace BellatrixDemosAutomationTests_FacadeDesignPattern
{
    public abstract class Driver
    {        
        public abstract void Start();
        public abstract void Quit();
        public abstract void GoToUrl(string url);
        public abstract Element FindElement(By locator);
        public abstract List<Element> FindElements(By locator);
        public abstract void WaitForAjax();
        public abstract void WaitUntilPageLoadsCompletely();
    }
}
