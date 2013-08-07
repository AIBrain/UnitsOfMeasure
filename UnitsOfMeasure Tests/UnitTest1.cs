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
        public void SpeedAndTimeGiveDisplacement()
        {
            var spd = new Velocity<Feet, Seconds> { Value = 10 };
            var time = new Seconds { Value = 5 };
            var disp = spd.Multiply(time);
            Assert.IsInstanceOfType(disp, typeof(Delta<Feet>));
            Assert.AreEqual(50, disp.Value);
        }

        [TestMethod]
        public void AccelerationAndTimeGiveSpeed()
        {
            var accel = new Acceleration<Feet, Seconds> { Value = 10 };
            var time = new Seconds { Value = 5 };
            var dspd = accel.Multiply(time);
            Assert.IsInstanceOfType(dspd, typeof(Delta<Velocity<Feet, Seconds>>));
            Assert.AreEqual(50, dspd.Value);

            var spd = dspd.Add(new Velocity<Feet, Seconds> { Value = 3 });
            Assert.IsInstanceOfType(spd, typeof(Velocity<Feet, Seconds>));
            Assert.AreEqual(53, spd.Value);

            var disp = spd.Multiply(time);
            Assert.IsInstanceOfType(disp, typeof(Delta<Feet>));
            Assert.AreEqual(265, disp.Value);
        }

        [TestMethod]
        public void SpeedOverTimeGivesAcceleration()
        {
            var dspd = new Delta<Velocity<Feet, Seconds>> { Value = 10 };
            var dt = new Delta<Seconds> { Value = 5 };
            var accel = dspd.Divide(dt);
            Assert.IsInstanceOfType(accel, typeof(Acceleration<Feet, Seconds>));
            Assert.AreEqual(2, accel.Value);
        }

        [TestMethod]
        public void TimeConversion1()
        {
            var spd = new Velocity<Feet, Seconds> { Value = 10 };
            var time = new Hours { Value = 1 };
            var ddist = spd.Multiply(time);
            Assert.IsInstanceOfType(ddist, typeof(Delta<Feet>));
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
