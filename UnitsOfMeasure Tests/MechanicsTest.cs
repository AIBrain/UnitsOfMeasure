using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitsOfMeasure.Time;
using UnitsOfMeasure.Length.Imperial;
using UnitsOfMeasure.Mechanics;
using UnitsOfMeasure.Angle;

namespace UnitsOfMeasure
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AccelerateSomething()
        {
            // setup an object with physical properties
            var accel = new Acceleration<Feet, Seconds> { Value = 10 };
            var spd = new Velocity<Feet, Seconds> { Value = 3 };
            var disp = new Feet { Value = 376 };

            // calculate the change over time and apply the changes
            var time = new Seconds { Value = 5 };
            Delta<Velocity<Feet, Seconds>> dspd = accel.Multiply(time);
            spd = dspd.Add(spd);
            Delta<Feet> ddisp = spd.Multiply(time);
            disp = disp.Add(ddisp);

            Assert.AreEqual(50, dspd.Value);
            Assert.AreEqual(53, spd.Value);
            Assert.AreEqual(265, ddisp.Value);
            Assert.AreEqual(641, disp.Value);
        }

        [TestMethod]
        public void SpeedAndTimeGiveDisplacement()
        {
            var spd = new Velocity<Feet, Seconds> { Value = 10 };
            var time = new Seconds { Value = 5 };
            var disp = spd.Multiply(time);
            Assert.IsInstanceOfType(disp, typeof(Delta<Feet>));
            Assert.AreEqual(50, disp.Value);
        }

        [TestMethod]
        public void SpeedOverTimeGivesAcceleration()
        {
            var dspd = new Delta<Velocity<Feet, Seconds>> { Value = 10 };
            var dt = new Delta<Seconds> { Value = 5 };
            Acceleration<Feet, Seconds> accel = dspd.Divide(dt);
            Assert.AreEqual(2, accel.Value);
        }

        [TestMethod]
        public void TimeConversion1()
        {
            var spd = new Velocity<Feet, Seconds> { Value = 10 };
            var time = new Hours { Value = 1 };
            Delta<Feet> ddist = spd.Multiply(time);
            Assert.AreEqual(36000, ddist.Value);
        }

        [TestMethod]
        public void CosineOnDegrees()
        {
            var d = new Degrees { Value = 45 };
            var v = d.Cos();
            Assert.AreEqual(Math.Sqrt(2) / 2, v);
        }

        [TestMethod]
        public void ArcCosineOnDegrees()
        {
            var v = Math.Sqrt(2) / 2;
            Degrees d = v.Acos();
            Assert.AreEqual(45, d.Value);
        }
    }
}
