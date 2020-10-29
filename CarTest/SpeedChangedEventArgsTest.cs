using Microsoft.VisualStudio.TestTools.UnitTesting;
using Automobile;
using System;

namespace KlariVisTest
{
    [TestClass]
    public class SpeedChangedEventArgsTest
    {
        private const int NEWSPEED = 15;
        [TestMethod]
        public void TestSpeedChangedEventArgsCreation()
        {
            var e = new SpeedChangedEventArgs
            {
                NewSpeed = NEWSPEED
            };
            Assert.AreEqual(NEWSPEED, e.NewSpeed);
        }

    }
}
