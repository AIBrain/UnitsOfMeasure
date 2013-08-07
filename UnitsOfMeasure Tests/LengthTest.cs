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

        [TestMethod]
        public void InchesToFeet()
        {
            var i = new Inches { Value = 24 };
            Feet f = i;
            Assert.AreEqual(2, f.Value);
        }

        [TestMethod]
        public void FeetToMiles()
        {
            var f = new Feet { Value = 7920 };
            Miles m = f;
            Assert.AreEqual(1.5, m.Value);
        }

        [TestMethod]
        public void MilesToInches()
        {
            var m = new Miles { Value = 3.5 };
            Inches i = m;
            Assert.AreEqual(221760, i.Value);
        }


        [TestMethod]
        public void AddInchesToFeet()
        {
            var f = new Feet { Value = 3.5 };
            var i = new Delta<Inches> { Value = 6 };
            f = f.Add(i);
            Assert.AreEqual(4, f.Value);
        }
    }
}
