using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CastroInterpolation.Tests
{
    [TestClass]
    public class CastroInterpolationTests
    {
        [TestCategory("Interpolation")]
        [TestMethod("Should Validate Linear Interpolation")]
        [DataRow(30, 3, 40, 5, 37, 4.4)]
        [DataRow(48, 827.55, 60, 1034.1677, 50, 861.9863)]
        [DataRow(10, 190, 48, 827.55, 30, 525.5526)]
        [DataRow(10, 56.22, 48, 112.44, 45, 108.0016)]
        public void ShouldValidateInterpolation(double x1, double y1, double x2, double y2, double x3, double expectedResult)
        {   

            Assert.AreEqual(Convert.ToDecimal(expectedResult), CastroInterpolation.CalculateInterpolation(Convert.ToDecimal(x1), Convert.ToDecimal(y1), Convert.ToDecimal(x2), Convert.ToDecimal(y2), Convert.ToDecimal(x3)));
        }
    }
}
