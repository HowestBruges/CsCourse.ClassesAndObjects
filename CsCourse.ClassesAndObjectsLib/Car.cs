using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCourse.ClassesAndObjectsLib
{
    public enum Brand { BMW, Volkswagen, Ford, Mercedes}

    public class Car
    {
        // Fields
        public int maxSpeed;
        public int actSpeed;
        public Brand carBrand;
        // Static Field
        public static int nrObjects = 0;

        // Constructor
        public Car()
        {
            nrObjects++;
        }

        public Car(Brand carBrand, int maxSpeed)
        {
            this.carBrand = carBrand;
            this.maxSpeed = maxSpeed;
            nrObjects++;
        }

        // Visualisatie van  AutoObject 
        public override string ToString()
        {
            return carBrand + "(" + maxSpeed +")";
        }

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
