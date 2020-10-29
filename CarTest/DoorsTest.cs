using Microsoft.VisualStudio.TestTools.UnitTesting;
using Automobile;
using System;

namespace KlariVisTest
{
    [TestClass]
    public class DoorsTest
    {
        private const int FIVEMILESPERHOUR = 5;
        private const int TWELVEMILESPERHOUR = 12;
        private const int FIFTEENMILESPERHOUR = 15;

        [TestMethod]
        public void TestInstantiateDoors()
        {
            var doors = new Doors(4);
            Assert.IsNotNull(doors);
        }

        [TestMethod]
        public void TestFourDoors()
        {
            var doors = new Doors(4);
            Assert.AreEqual(4, doors.NumberOfDoors);
        }

        [TestMethod]
        public void TestHandleSpeedChangedFiveMilesPerHour()
        {
            var doors = new Doors(4);
            doors.HandleSpeedChanged(this, new SpeedChangedEventArgs { NewSpeed = FIVEMILESPERHOUR });
            Assert.IsFalse(doors.CheckIfAllDoorsAreLocked());
        }

        [TestMethod]
        public void TestHandleSpeedChangedTwelveMilesPerHour()
        {
            var doors = new Doors(4);
            doors.HandleSpeedChanged(this, new SpeedChangedEventArgs { NewSpeed = TWELVEMILESPERHOUR }) ;
            Assert.IsFalse(doors.CheckIfAllDoorsAreLocked());
        }

        [TestMethod]
        public void TestHandleSpeedChangedFifteenMilesPerHour()
        {
            var doors = new Doors(4);
            doors.HandleSpeedChanged(this, new SpeedChangedEventArgs { NewSpeed = FIFTEENMILESPERHOUR });
            Assert.IsTrue(doors.CheckIfAllDoorsAreLocked());
        }

    }
}
