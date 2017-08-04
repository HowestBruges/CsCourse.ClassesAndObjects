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

        // Constructor
        public Car()
        {

        }

        public Car(Brand carBrand, int maxSpeed)
        {
            this.carBrand = carBrand;
            this.maxSpeed = maxSpeed;
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

    }
}
