using System;
using System.Diagnostics.CodeAnalysis;

namespace Automobile
{
    public class Car : IEquatable<Car>, IComparable<Car>
    {
        private const int DEFAULTNUMBEROFDOORS = 4;

        public event EventHandler<SpeedChangedEventArgs> SpeedChanged;

        public int CurrentSpeedInMilesPerHour = 0;

        public Doors doors;

        public Car()
        {
        }

        public void Initialize(int NumberOfDoors = DEFAULTNUMBEROFDOORS)
        {
            doors = new Doors(NumberOfDoors);
            SpeedChanged += doors.HandleSpeedChanged;
        }

        /// <summary>
        /// Starts the car moving up to a certain speed.
        /// </summary>
        /// <param name="speed"></param>
        public void Accelerate(int speed)
        {
            // Set the current speed 
            CurrentSpeedInMilesPerHour = speed;

            var speedData = new SpeedChangedEventArgs
            {
                NewSpeed = speed
            };
            OnSpeedChanged(speedData);
        }

        protected virtual void OnSpeedChanged(SpeedChangedEventArgs e)
        {
            SpeedChanged?.Invoke(this, e);
        }

        public bool Equals([AllowNull] Car other)
        {
            if (other.CurrentSpeedInMilesPerHour == CurrentSpeedInMilesPerHour && other.doors.NumberOfDoors == doors.NumberOfDoors)
            {
                return true;
            }
            return false;
        }

        public int CompareTo([AllowNull] Car other)
        {
            if (other.CurrentSpeedInMilesPerHour == CurrentSpeedInMilesPerHour && other.doors.NumberOfDoors == doors.NumberOfDoors)
            {
                return 1;
            }
            return 0;
        }
    }

}
