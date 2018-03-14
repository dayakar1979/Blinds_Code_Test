using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElectronicRatingCalculatorComponent;

namespace TestProject
{
    [TestClass]
    public class ERCalculator
    {
        [TestMethod]
        public void CalculateTest()
        {
            IOhmValueCalculator calculatorClient = new OhmValueCalculator();

            var actualResult = calculatorClient.CalculateOhmValue("Red", "Black", "Red", "Red");

            Assert.AreEqual(new Tuple<double, double>(2000, 2), actualResult, "CalculateTest");

            actualResult = calculatorClient.CalculateOhmValue("Silver", "Silver", "Silver", "Silver");

            Assert.AreEqual(new Tuple<double, double>(-0.33, 10), actualResult, "CalculateTest");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullExceptionTest()
        {
            var expectedParamName = "bandAColor";
            try
            {
                IOhmValueCalculator calculatorClient = new OhmValueCalculator();
                calculatorClient.CalculateOhmValue(null, "Silver", "Silver", "Silver");
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual(expectedParamName, ex.ParamName);
            }

            
        }
    }


}
