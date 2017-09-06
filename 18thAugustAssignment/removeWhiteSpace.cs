using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _18thAugustAssignment
{
    class removeWhiteSpace
    {


        public void removeSpace()
        {
            string str = "Pooja    Newase";
            string strnew=Regex.Replace(str,@"\s+"," ");
            Console.WriteLine("New string : " + strnew);
        }
    }
}
