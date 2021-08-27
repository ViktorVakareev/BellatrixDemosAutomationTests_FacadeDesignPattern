using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixDemosAutomationTests_FacadeDesignPattern
{
    public partial class CheckoutPage : BasePage
    {
        public CheckoutPage(Driver driver) : base(driver)
        {
        }
        protected override string Url => "https://demos.bellatrix.solutions/checkout/";

        protected override void WaitForPageLoad()
        {
            //TODO
        }
    }
}
