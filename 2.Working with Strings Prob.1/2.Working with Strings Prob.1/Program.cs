/*
 * Working with Strings 
 * Problem 1.	Reverse String
 * Write a program that reads a string from the console, reverses it and prints the result back at the console.
 *
 * Input	Output
 * sample	elpmas
 * 24tvcoi92	29iocvt42
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Working_with_Strings_Prob._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working with Strings - Reverse String");

            Console.Write("Input a string: ");
            string inputValue = Console.ReadLine();
            char[] arrayValue = inputValue.ToCharArray();

            Console.Write("Reversed string: ");
            for(int i= arrayValue.Length-1; i>=0; i--)
                Console.Write(arrayValue[i]);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
