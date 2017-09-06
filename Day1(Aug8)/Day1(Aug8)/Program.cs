using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Aug8_
{
    class Program
    {
        static void Main(string[] args)
        {
            bird1 b1 = new bird1();
            bird2 b2 = new bird2();
            Console.WriteLine("Challenge 1");
            b1.fly();
            b1.walk();

            b2.sing();
            b2.walk();

            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Challenge 2");
            addOverloading ad = new addOverloading();
            ad.add(1, 2);
            ad.add(1,2, 3);
            ad.add(1,2,3,4);
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Challenge 3");


            email_sms emsm = new email_sms();
            emsm.msgsent();

           email_sms em = new viaEmail();
            em.msgsent();
            email_sms sm = new viaSms();
            sm.msgsent();
            Console.WriteLine("------------------------------------------------------------------------------");

           employee emp = new employee(2000);

            emp = new trainer(1000);
            emp.calculate();

            emp = new admin(5000);
            emp.calculate();

            emp = new hr(3000);
            emp.calculate();

            Console.ReadLine();

        }
    }
}
