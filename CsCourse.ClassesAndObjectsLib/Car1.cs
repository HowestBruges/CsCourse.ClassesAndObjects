using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCourse.ClassesAndObjectsLib
{
    public partial class Car
    {
        public void IncreaseSpeed(int amount)
        {
            actSpeed += amount;
            if (actSpeed > maxSpeed)
            {
                actSpeed = maxSpeed;
            }
        }

        public void DecreaseSpeed(int amount)
        {
            actSpeed -= amount;
            if (actSpeed < 0)
            {
                actSpeed = 0;
            }
        }

        // Static Method
        public static int CompareSpeed(Car Car1, Car Car2)
        {
            return Car1.maxSpeed - Car2.maxSpeed;
        }
    }
}
