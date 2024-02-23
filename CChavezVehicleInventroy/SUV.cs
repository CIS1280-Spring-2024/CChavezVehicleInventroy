using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CChavezVehicleInventory
{
    internal class SUV : Vehicle
    {

        public SUV(string vin, string license)
        {
            VIN = vin;
            LicensePlate = license;
        }

        private int wheels = 4;
        public override int Wheels
        {
            get { return wheels; }
        }

        public override int MaxPassengers
        {
            get
            {
                return 8;
            }
        }

        public override string ToString()
        {
            return "SUV License Plate: " + LicensePlate +
                " VIN " + VIN;
        }

        public override string GetDescription()
        {
            return "SUV License Plate: " + LicensePlate +
                " VIN " + VIN + " Wheels: " + wheels + " Passengers: " + MaxPassengers; ;
        }
    }
}
