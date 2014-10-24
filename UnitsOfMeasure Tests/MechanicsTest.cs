namespace UnitsOfMeasure_Tests {
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using UnitsOfMeasure;
    using UnitsOfMeasure.Angle;
    using UnitsOfMeasure.Length.Imperial;
    using UnitsOfMeasure.Mechanics;
    using UnitsOfMeasure.Time;

    [TestClass]
    public class MechanicsTest {

        [TestMethod]
        public void AccelerateSomething() {

            // setup an object with physical properties
            var accel = new Acceleration<Feet, Seconds> {
                Value = 10
            };
            var spd = new Velocity<Feet, Seconds> {
                Value = 3
            };
            var disp = new Feet {
                Value = 376
            };

            // calculate the change over time and apply the changes
            var time = new Seconds {
                Value = 5
            };
            var dspd = accel.Multiply( time );
            spd = dspd.Add( spd );
            var ddisp = spd.Multiply( time );
            disp = disp.Add( ddisp );

            Assert.AreEqual( 50, dspd.Value );
            Assert.AreEqual( 53, spd.Value );
            Assert.AreEqual( 265, ddisp.Value );
            Assert.AreEqual( 641, disp.Value );
        }

        [TestMethod]
        public void ArcCosineOnDegrees() {
            var v = Math.Sqrt( 2 ) / 2;
            Degrees d = v.Acos();
            Assert.AreEqual( 45, d.Value );
        }

        [TestMethod]
        public void CosineOnDegrees() {
            var d = new Degrees {
                Value = 45
            };
            var v = d.Cos();
            Assert.AreEqual( Math.Sqrt( 2 ) / 2, v );
        }

        [TestMethod]
        public void DriveForAFewSeconds() {
            var spd = new Velocity<Miles, Hours> {
                Value = 55
            };
            var disp = new Feet {
                Value = 0
            };
            var time = new Seconds {
                Value = 5
            };
            var ddisp = spd.Multiply( time );
            disp = disp.Add( ( Feet )ddisp );

            Assert.AreEqual( 0.07638888888888888888888888888889, ddisp.Value, 1e-10 );
            Assert.AreEqual( 403.33333333333333333333333333333, disp.Value, 1e-10 );
        }

        [TestMethod]
        public void SpeedAndTimeGiveDisplacement() {
            var spd = new Velocity<Feet, Seconds> {
                Value = 10
            };
            var time = new Seconds {
                Value = 5
            };
            var disp = spd.Multiply( time );
            Assert.AreEqual( 50, disp.Value );
        }

        [TestMethod]
        public void SpeedOverTimeGivesAcceleration() {
            var dspd = new Velocity<Feet, Seconds> {
                Value = 10
            };
            var dt = new Seconds {
                Value = 5
            };
            var accel = dspd.Divide( dt );
            Assert.AreEqual( 2, accel.Value );
        }

        [TestMethod]
        public void TimeConversion1() {
            var spd = new Velocity<Feet, Seconds> {
                Value = 10
            };
            var time = new Hours {
                Value = 1
            };
            var ddist = spd.Multiply( time );
            Assert.AreEqual( 36000, ddist.Value );
        }
    }
}