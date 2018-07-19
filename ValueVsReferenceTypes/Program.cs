using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueVsReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // These are Values (most basic data types)
            int a = 10;
            int b = a;
            b++;

            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));  // 10, 11


            // Classes and such are reference types

            int[] array1 = new int[3] { 1, 2, 3 };  // This creates a new spot in memory for this data
            int[] array2 = array1;   // This is actually just a pointer to the same location in memory

            array2[0] = 0;
            // array1[0] will now ALSO be 0



        }
    }
}
