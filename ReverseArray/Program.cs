using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 1, 2, 3, 4, 5 };

            Console.WriteLine("An Array:");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i] + "\t");
            }

            Console.WriteLine("\n");

            Console.WriteLine("In Reverse order:");
            for (int m = Array.Length - 1; m >= 0; m--)
            {
                Console.Write(Array[m] + "\t");
            }

            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
