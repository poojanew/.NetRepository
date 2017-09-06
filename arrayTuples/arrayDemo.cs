using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayTuples
{
    class arrayDemo
    {
        public void printSArray()
        {
            int[] singleDimensionArray = { 1, 35, 5, 33, 4, 66 };

            Console.WriteLine("\n\nSingle Dimension Array");
            foreach (var item in singleDimensionArray)
            {
                Console.Write(item + "\t");
            }

        }

        public void printMArray()
        {
            string[,] multiDimensionarray = new string[,]
            {
                {"cat", "dog"},
                {"bird", "fish"},
            };
            Console.WriteLine("\n\nMulti Dimension Array");
            Console.WriteLine(multiDimensionarray[0, 0]);
            Console.WriteLine(multiDimensionarray[0, 1]);
            Console.WriteLine(multiDimensionarray[1, 0]);
            Console.WriteLine(multiDimensionarray[1, 1]);
          
           
        }

        public void jaggedArray()
        {
            int[][] jaggedArray = new int[3][];

            // Create a new array in the jagged array, and assign it.
            jaggedArray[0] = new int[2];
            jaggedArray[0][0] = 1;
            jaggedArray[0][1] = 2;

            // Set second row, initialized to zero.
            jaggedArray[1] = new int[1];

            // Set third row, using array initializer.
            jaggedArray[2] = new int[3] { 3, 4, 5 };

            Console.WriteLine("\n\nJagged Array");
            // Print out all elements in the jagged array.
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int[] innerArray = jaggedArray[i];
                for (int a = 0; a < innerArray.Length; a++)
                {
                    Console.Write(innerArray[a] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
