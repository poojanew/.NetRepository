using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_classes
{
    interface IVehicleDisplay
    {
        void displayInfo();
     
    }
    class vehicleInterface : IVehicleDisplay
    {
         string vehicle_name;

         string color;
         int price;

    public vehicleInterface(string name, string col, int pr)
        {
            vehicle_name = name;
            color = col;
            price = pr;
     
        }

        public void displayInfo()
        {
            Console.WriteLine("\n{0}\nColor : {1}\nPrice : {2}", vehicle_name, color, price);
        }
    }
}
