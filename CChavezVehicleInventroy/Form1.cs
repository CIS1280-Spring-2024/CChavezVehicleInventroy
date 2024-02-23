using CChavezVehicleInventory;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data.Common;
using System.Security.Principal;
using System.Threading.Channels;

namespace CChavezVehicleInventroy
{
    public partial class Form1 : Form
    {
        //  6.12.	Add a List of Vehicles to your form class:
        private List<Vehicle> vehicles = new List<Vehicle>();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (cbType.Text == "Sedan")
            {
                Sedan sedan = new Sedan();
                sedan.LicensePlate = txbLicense.Text;
                sedan.VIN = txbVIN.Text;
                vehicles.Add(sedan);
                //Refresh the list box
                lbInventory.DataSource = null;
                lbInventory.DataSource = vehicles;
                txbResults.Text = "Successfuly added sedan";
            }
            else if (cbType.Text == "Truck")
            {
                Truck truck = new Truck(txbVIN.Text, txbLicense.Text);
                vehicles.Add(truck);
                //Refresh the list box
                lbInventory.DataSource = null;
                lbInventory.DataSource = vehicles;
                txbResults.Text = "Successfuly added truck";
                //  6.14.The DataSource property is used to identify
                //      a collection object that the ListBox will
                //      display. To refresh it you must point it to
                //      null then re-assign it to cause the ListBox
                //      to refresh.
            }

        }

        private void lbInventory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //  6.16.   Clicking on the ListBox control would create an index changed
            //          event. However, for this program we want a double click event.
            //  6.17.	Select the ListBox and then click on the lightning bolt
            //          in the Properties window:
            //  6.18.	Double click in the MouseDoubleClick
            //          event and add the following event handler:
            Vehicle vehicle = (Vehicle)lbInventory.SelectedItem;
            txbSummary.Text = vehicle.GetDescription();
            //  6.19.Notice that we cast lbInventory.SelecedItem to Vehicle
            //  class. The list boxe’s SelectedItem property is an Object
        }
    }
}
