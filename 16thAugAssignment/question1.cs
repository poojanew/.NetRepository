using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16thAugAssignment
{
    class question1
    {
        public delegate void calculateSimpleInterest(int principal, int year);
        public delegate void bank_message(string msg);
        public event bank_message msg_event;

        public void GetTotalInterest(int principal, int year)
        {
            int simple_interest = (principal * year * 5) / 100;
            Console.WriteLine("Principal amount : {0}\nYear : {1}\nSimple Interest : {2}", principal, year, simple_interest);
        }

        public void getInterestRatePerYear(int principal, int year)
        {
            Console.WriteLine("Amount is calculated at rate {0}% per year", year);
        }

        public void RaiseEvent(string message)
        {
            if (msg_event != null)
                msg_event(message);
        }

        public static void print_event_msg(string msg)
        {
            Console.WriteLine("Message for you : {0}", msg);
        }
    }
}
