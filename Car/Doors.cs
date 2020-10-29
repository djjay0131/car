using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Automobile
{
    public class Doors
    {
        private const int DOORLOCKSPEEDTHRESHOLD = 12;

        public event EventHandler DoorLockThresholdReached;

        public int NumberOfDoors
        {
            get
            {
                return doors.Count();
            }
        }

        public List<Door> doors = new List<Door>();

        public Doors(int numberOfDoors)
        {
            for (int i = 0; i < numberOfDoors; i++)
            {
                Door door = new Door();
                DoorLockThresholdReached += door.HandleDoorLockThresholdReached;
                doors.Add(door);
            }
        }

        public bool CheckIfAllDoorsAreLocked()
        {
            return doors.All(d => d.IsLocked);
        }

        public void HandleSpeedChanged(object sender, SpeedChangedEventArgs e)
        {
            if (e.NewSpeed > DOORLOCKSPEEDTHRESHOLD)
            {
                DoorLockThresholdReached?.Invoke(this, e);
            }
        }
    }
}
