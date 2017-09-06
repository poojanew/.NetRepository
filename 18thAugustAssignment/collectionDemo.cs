using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18thAugustAssignment
{
    class collectionDemo
    {
        public void demoTest()
        {
            List<string> strList = new List<string>();
            strList.Add("Mon");
            strList.Add("Tue");
            strList.Add("Wed");
            strList.Add("Thu");
            strList.Add("Fri");
            strList.Add("Sat");
            strList.Add("Sun");

            foreach (var item in strList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n\nAfter deleting");
            strList.Remove("Sat");
            foreach (var item in strList)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("\n\nAfter updating");
            var index = strList.IndexOf("Sun");
            strList.Insert(strList.IndexOf("Sun"), "Sat");
            strList["Sun"] = "Funday";
            foreach (var item in strList)
            {
                Console.WriteLine(item);

            }



        }
    }
}
