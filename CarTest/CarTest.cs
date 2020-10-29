using Microsoft.VisualStudio.TestTools.UnitTesting;
using Automobile;

namespace KlariVisTest
{
    [TestClass]
    public class CarTest : Car
    {
        readonly Car DefaultCar = new Car();
        readonly Car FiveDoorCar = new Car();

        [TestInitialize]
        public void InitializeCars()
        {
            DefaultCar.Initialize();
            FiveDoorCar.Initialize(5);
        }

        private const int FIVEMILESPERHOUR = 5;
        private const int TWELVEMILESPERHOUR = 12;
        private const int FIFTEENMILESPERHOUR = 15;

        [TestMethod]
        public void TestCarCreation()
        {
            Assert.IsNotNull(DefaultCar);
        }

        // Doors should be locked when the car reach 13 MPH
        [TestMethod]
        public void TestDoorsLockedAtFiveMilePerHour()
        {
            // Car at 5 MPH
            DefaultCar.Accelerate(FIVEMILESPERHOUR);
            Assert.IsTrue(!DefaultCar.doors.CheckIfAllDoorsAreLocked());
        }

        [TestMethod]
        public void TestDoorsLockedAtTwelveMilePerHour()
        {
            // Car at 5 MPH
            DefaultCar.Accelerate(TWELVEMILESPERHOUR);
            Assert.IsTrue(!DefaultCar.doors.CheckIfAllDoorsAreLocked());
        }

        [TestMethod]
        public void TestDoorsLockedAtFifteenMilePerHour()
        {
            // Car at 15 MPH
            DefaultCar.Accelerate(FIFTEENMILESPERHOUR);
            Assert.IsTrue(DefaultCar.doors.CheckIfAllDoorsAreLocked());
        }

        [TestMethod]
        public void TestFiveDoorCarHasFiveDoors()
        {
            Assert.AreEqual(5, FiveDoorCar.doors.NumberOfDoors);
        }

        [TestMethod]
        public void TestZeroDoorCarHasZeroDoors()
        {
            var car = new Car();
            car.Initialize(0);
            Assert.AreEqual(0, car.doors.NumberOfDoors);
        }

    }
}
