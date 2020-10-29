using System;
using System.Collections.Generic;
using System.Text;

namespace Automobile
{
    public class Door
    {
        public bool IsLocked = false;

        public Door()
        { }

        public void Lock()
        {
            IsLocked = true;
        }

        public void Unlock()
        {
            IsLocked = false;
        }

        public void HandleDoorLockThresholdReached(object sender, EventArgs e)
        {
            Lock();
        }
    }
}
