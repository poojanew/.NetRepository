using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    public class customException : Exception
    {
        public customException(string message):base(message)
        {

        }
    }

    public class customDemo
    {
        int temp = 0;
        public void showTemp()
        {
            string msg = "Zero Temperature";
            try
            {
                if (temp == 0)
                {
                    throw (new customException(msg));
                }

                else
                {
                    Console.WriteLine("Temperature is not {0}", temp);
                }
            }
            catch(customException custome)
            {
                Console.WriteLine(custome.Message);
            }
                
        }
    }
}
