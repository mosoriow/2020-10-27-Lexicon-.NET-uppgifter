/*
 * Working with Strings 
 * Problem 2.	String Length
 * Write a program that reads from the console a string of maximum 20 characters. If the length 
 * of the string is less than 20, the rest of the characters should be filled with *. Print the 
 * resulting string on the console.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Working_with_Strings_Prob._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Length");

            Console.Write("type a string: ");
            string inputString = Console.ReadLine();
            string outputString="";

            if (inputString.Length >= 20)
                outputString = inputString.Substring(0, 20);
            else
                outputString = inputString + new string('*', 20 - inputString.Length);

            Console.Write("first 20 characters: ");
            Console.WriteLine(outputString);

            Console.ReadKey();
        }
    }
}
