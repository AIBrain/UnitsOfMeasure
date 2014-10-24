using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitsOfMeasure.Time;

namespace UnitsOfMeasure_Tests {

    [TestClass]
    public class TimeTest {

        [TestMethod]
        public void SecondsToMinutes() {
            var sec = new Seconds {
                Value = 120
            };
            Minutes m = sec;
            Assert.AreEqual( 2, m.Value );
        }
    }
}