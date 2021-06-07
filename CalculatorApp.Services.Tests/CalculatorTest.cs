using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp.Services;
namespace CalculatorApp.Services.Tests
   
{
    [TestClass]
    public class CalculatorTest
    {

        Calculator _calc;

        public CalculatorTest()
        {
            _calc = new Calculator();
        }

        [TestMethod]
        public void Add()
        {
            int res = _calc.Add(5, 3);
            Assert.AreEqual(res, 8);
        }

        [TestMethod]
        public void Sub()
        {
            int res = _calc.Sub(5, 3);
            Assert.AreEqual(res, 2);
        }
    }
}
