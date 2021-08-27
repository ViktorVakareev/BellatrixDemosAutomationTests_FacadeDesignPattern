using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixDemosAutomationTests_FacadeDesignPattern
{
    public partial class CartPage : BasePage
    {
        public CartPage(Driver driver)
            :base(driver)
        {
        }
        protected override string Url => "https://demos.bellatrix.solutions/cart/";

        protected override void WaitForPageLoad()
        {
            //TODO
        }
    }
}
