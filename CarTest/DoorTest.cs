using Microsoft.VisualStudio.TestTools.UnitTesting;
using Automobile;
using System;

namespace KlariVisTest
{
    [TestClass]
    public class DoorTest
    {
        [TestMethod]
        public void TestInstantiateDoor()
        {
            var door = new Door();
            Assert.IsNotNull(door);
        }

        [TestMethod]
        public void TestDoorLocks()
        {
            var door = new Door();
            door.Lock();
            Assert.IsTrue(door.IsLocked);
        }

        [TestMethod]
        public void TestDoorUnLocks()
        {
            var door = new Door();
            door.Unlock();
            Assert.IsFalse(door.IsLocked);
        }

        [TestMethod]
        public void TestHandleDoorLockThresholdReached()
        {
            var door = new Door();
            door.HandleDoorLockThresholdReached(this, EventArgs.Empty);
            Assert.IsTrue(door.IsLocked);
        }
    }
}
