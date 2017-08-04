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
        
        // Visualisatie van  AutoObject 
        public override string ToString()
        {
            return carBrand + "(" + maxSpeed +")";
        }


    }
}
