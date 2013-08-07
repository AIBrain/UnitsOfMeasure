using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitsOfMeasure;
using UnitsOfMeasure.Length;
using UnitsOfMeasure.Length.Imperial;

namespace UnitsOfMeasure_Tests
{
    [TestClass]
    public class LengthTest
    {
        [TestMethod]
        public void Area1()
        {
            var x = new Feet { Value = 5 };
            var y = new Feet { Value = 7 };
            Area<Feet> a = x.Multiply(y);
            Assert.AreEqual(35, a.Value);
        }
    }
}
