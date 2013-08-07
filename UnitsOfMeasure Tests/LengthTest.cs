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

        [TestMethod]
        public void Volume1()
        {
            var x = new Feet { Value = 3 };
            var y = new Feet { Value = 5 };
            var z = new Feet { Value = 7 };
            Volume<Feet> v = x.Multiply(y).Multiply(z);
            Assert.AreEqual(105, v.Value);
        }
    }
}
