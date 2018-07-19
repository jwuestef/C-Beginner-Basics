using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            //// Length - arrays have a fixed size
            //Console.WriteLine("Length: " + numbers.Length);

            //// IndexOf
            //Console.WriteLine(Array.IndexOf(numbers, 9));

            //// Clear() - clear the first two numbers of this array (set them to zero... if array of booleans then it will set to false)
            //Array.Clear(numbers, 0, 2);

            //// Copy() - copies elements from one array into another... copy the first 3 elements into another array
            //int[] another = new int[3];
            //Array.Copy(numbers, another, 3);

            //// Sort() - sorts the elements
            //Array.Sort(another);

            //// Reverse() - reverses the array
            //Array.Reverse(another);



            // LISTS - have dynamic size, arrays are fixed size

            List<int> numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });
            foreach (int number in numbers)
                Console.WriteLine(number);

            numbers.IndexOf(1);
            numbers.LastIndexOf(1);
            numbers.Count(); // how many numbers are in the list
            numbers.Remove(1); // removes the first occurance of the number





        }
    }
}
