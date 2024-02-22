using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CChavezVehicleInventory
{
    //  4.1.	Make a sedan class that inherits from the Vehicle class:
    //class Sedan : Vehicle
    //{

    //}

    //  4.2.	Notice that Sedan has a red squiggle.Hovering over it notice that visual studio tells us we must implement GetDescription, Wheels property and MaxPassengers property!
    //  4.3.	Add the following code:
    public class Sedan : Vehicle
    {
        private int wheels = 4;
        public override int Wheels
        {
            get { return wheels; }
        }

        public override int MaxPassengers
        {
            get
            {
                return 5;
            }
        }

        public override string GetDescription()
        {
            return "Sedan License Plate: " + LicensePlate +
                " VIN " + VIN + " Wheels: " + wheels + " Passengers: " + MaxPassengers;
        }
        //  4.4.	Let’s also override ToString:
        public override string ToString()
        {
            return "Sedan License Plate: " + LicensePlate +
                " VIN " + VIN;
        }

    }

}
