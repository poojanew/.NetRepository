using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16thAugAssignment
{
    class Program
    {



        private static void callDelegate(Program p)
        {
            question1 que1obj = new question1();
            question1.calculateSimpleInterest calInterest = new question1.calculateSimpleInterest(que1obj.GetTotalInterest);
            calInterest += new question1.calculateSimpleInterest(que1obj.getInterestRatePerYear);
            calInterest(10000, 5);

           
        }

       
        static void Main(string[] args)
        {
            Program p = new Program();
            callDelegate(p);
            question1.calculateSimpleInterest calInterest = delegate (int principal, int year)
            {
                double compound_interest = principal*Math.Pow( ((4+5)/5),4*year);
                Console.WriteLine("Compound Interest : {0}", compound_interest);
            };

            calInterest(10000, 5);

            Console.WriteLine("---------------------------------------------------");

            question1 eventObj = new question1();
            eventObj.msg_event += new question1.bank_message(question1.print_event_msg);
            eventObj.RaiseEvent("Welcome to HDFC");

            Console.WriteLine("---------------------------------------------------");

            employee e1 = new employee();
            e1.displayEmpList();

            Console.ReadLine();
        }

        

       
    }
}
