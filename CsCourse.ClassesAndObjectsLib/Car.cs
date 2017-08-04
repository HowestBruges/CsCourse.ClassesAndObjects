using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCourse.ClassesAndObjectsLib
{
    public enum Brand { BMW, Volkswagen, Ford, Mercedes}

    public partial class Car
    {
        // Fields
        public int maxSpeed;
        public int actSpeed;
        public Brand carBrand;
        // Static Field
        public static int nrObjects = 0;
        public static Random rd = new Random();

        // Constructor
        public Car()
        {
            carBrand = (Brand)rd.Next(0, Enum.GetNames(typeof(Brand)).Length);
            maxSpeed = rd.Next(180, 301);
            nrObjects++;
        }

        public Car(Brand carBrand, int maxSpeed):this()
        {
            this.carBrand = carBrand;
            this.maxSpeed = maxSpeed;
           
        }

        // Visualisatie van  AutoObject 
        public override string ToString()
        {
            return carBrand + "(" + maxSpeed +")";
        }

       

    }
}
