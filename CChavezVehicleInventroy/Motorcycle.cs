using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CChavezVehicleInventory
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string vin, string license)
        {
            VIN = vin;
            LicensePlate = license;
        }

        private int wheels = 2;
        public override int Wheels
        {
            get { return wheels; }
        }

        public override int MaxPassengers
        {
            get
            {
                return 1;
            }
        }

        public override string ToString()
        {
            return "Motorcycle License Plate: " + LicensePlate +
                " VIN " + VIN;
        }

        public override string GetDescription()
        {
            return "Motorcycle License Plate: " + LicensePlate +
                " VIN " + VIN + " Wheels: " + wheels + " Passengers: " + MaxPassengers; ;
        }
    }
}
