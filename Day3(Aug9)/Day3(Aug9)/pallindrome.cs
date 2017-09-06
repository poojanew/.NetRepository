using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Aug9_
{
    class pallindrome
    {
        string revstr="";

        public void check()
        {
            Console.WriteLine("Enter string : ");
            string str = Convert.ToString(Console.ReadLine());
          
              int len = str.Length;
            Console.WriteLine(len);
            for (int i = len-1; i >=0; i--)
            {
                revstr += str[i].ToString();
            }

            if (revstr == str)
            {
                Console.WriteLine("Pallindrome",revstr);
            }
            else
            {
                Console.WriteLine("Not Pallindrome");
            }

            Console.ReadLine();

        }
    }
}
