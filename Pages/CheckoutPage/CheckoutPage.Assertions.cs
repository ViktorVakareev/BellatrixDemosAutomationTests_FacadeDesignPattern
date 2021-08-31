using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixDemosAutomationTests_FacadeDesignPattern
{
    public partial class CheckoutPage
    {
       public void AssertRequiredFieldsErrorMessage()
        {
            string expectedMessage = "Billing First name";
            Assert.AreEqual(expectedMessage, MissingRequiredFieldsMessage("First name").Text);
        }
    }
}
