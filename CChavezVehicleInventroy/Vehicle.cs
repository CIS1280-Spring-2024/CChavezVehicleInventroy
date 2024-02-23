using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CChavezVehicleInventory
{
    //  3.1.	Create an abstract class that represents the common attributes of our vehicles:
    public abstract class Vehicle
    {
        public string VIN { get; set; }

        public string LicensePlate { get; set; }

        public abstract int Wheels { get; }

        public abstract int MaxPassengers { get; }

        public abstract string GetDescription();

        //  3.2.	Notice that some of our properties/methods are concrete and some are declared abstract.
        //
        //          Class notes Abstracts are reqierments in inheriting an abstract class
        //          You can only  override abstract and virtual
        //
    }

}
