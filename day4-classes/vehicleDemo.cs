using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_classes
{
    class vehicleDemo
    {
       public string vehicle_name;
        
       public string color;
       public int price;

        public vehicleDemo()
        {
            this.vehicle_name = "Vehicle";
            this.color = null;
            this.price = 0;
        }

        public virtual void displayIndo()
        {
            Console.WriteLine("\n{0}\nColor : {1}\nPrice : {2}",vehicle_name,color,price);
        }

    }

     class car : vehicleDemo
    {
        string car_type;
       public car(string name,string col,int pr,string cart)
        {
            vehicle_name = name;
            color = col;
            price = pr;
            car_type = cart;
        }

        public override void displayIndo()
        {
            Console.WriteLine("\n{0}\nColor : {1}\nPrice : {2}\nCar Type : {3}", vehicle_name, color, price,car_type);

        }

    }

   
}
