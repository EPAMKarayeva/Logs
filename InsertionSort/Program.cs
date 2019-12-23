using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array = new int[10];

            ArraySorting arraySorting = new ArraySorting();
            arraySorting.FillArray(array);
            Console.WriteLine("Before sort:");

            foreach (int item in array)
            {
                Console.Write(item + " ");
            }

            arraySorting.ArrayInsertionSorting(array);
            Console.WriteLine("\nAfter sort:");

            foreach (int item in array)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();

        }
    }
}
