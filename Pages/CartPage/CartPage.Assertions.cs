using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixDemosAutomationTests_FacadeDesignPattern
{
    public partial class CartPage
    {
        public void AssertCorrectRocketAddedToCart(string expectedRocketName)
        {
            string actualRocketName = ProductNameField.Text;
            Assert.AreEqual(actualRocketName, expectedRocketName);
        }
    }
}
