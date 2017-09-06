using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*partialClass1 p = new partialClass1();
            p.a();
            p.ba();
            Console.WriteLine("----------------------------------------------");
            staticClassEx.degreeToRadian(180);
            Console.WriteLine("----------------------------------------------");

            int a = 122143;
            Console.WriteLine("This is " + a.digitCount() + " digit number");

            Console.WriteLine("----------------------------------------------");

            IEmployee iobj = new interfaceEx();
            iobj.calculateSalary(1000);
            iobj.empName("Pooja");*/

            /*   int a, b;
               Console.WriteLine("Enter two numbers");
               a = Convert.ToInt32(Console.ReadLine());
               b = Convert.ToInt32(Console.ReadLine());

               a = a + b;
               b = a - b;
               a = a - b;

               Console.WriteLine("a is : {0} and b is {1}", a, b);
              
            int a;
        
                Console.WriteLine("Enter number");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Table");

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(a * i);
                } 

            string str,newstr;
            Console.WriteLine("Enter string");
            str = Convert.ToString(Console.ReadLine());
            //int index;
            for (int i = 0; i < str.Length; i++)
            {
               
                
                if(str[i]=='a'|| str[i] == 'e'|| str[i] == 'i'|| str[i] == 'o'|| str[i] == 'u')
                {
                    str = str.Replace(str[i], ' ');
                    //str = str.Remove(i);
                }
            }

            Console.WriteLine("New String : ");
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i]!=' ')
                {
                    Console.Write(str[i]);

                }
            }
            */


            /*Challenge 1
            string s = "pooja newase";
           
           string news= s.toUpperCase();
           Console.WriteLine(news);*/

            /*challenge 2
            car c = new car("i-10","black",900000,"car");
            c.displayIndo();
            */

            /*Challenge 3
            IVehicleDisplay vd=new vehicleInterface("i - 10","black",900000);
            vd.displayInfo();*/

            int result = staticclassdemo.area(5,8);
            Console.WriteLine("Rectangle area : " + result);

            Console.ReadLine();
        }
    }

    public partial class partialClass1{

        public void a()
        {
            Console.WriteLine("in 1st partial class"); 
        }

   

    }



}
