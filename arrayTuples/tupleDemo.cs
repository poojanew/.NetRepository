using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayTuples
{
    enum trainingDetails{DotNet,Java,Angular2};
    class tupleDemo
    {
        public void displayTuple()
        {
            string id = "X5212";
            var employee = Tuple.Create(id, "Pooja", "Associate Software Engineer", trainingDetails.DotNet);
            Console.WriteLine("ID : {0}\nNAME : {1}\nTRAINING : {2}", employee.Item1, employee.Item2, employee.Item4);

            var numberTuple = new Tuple<int,int,int,int,int,int,int,Tuple<int,int>>(1,2,3,5,6,7,8, Tuple.Create(11,22));
            Console.WriteLine("{0},{1},{2},{3}", numberTuple.Item1, numberTuple.Item2, numberTuple.Item3, numberTuple.Rest.Item1);
        }
    }
}
