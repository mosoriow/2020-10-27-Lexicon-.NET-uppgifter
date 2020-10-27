﻿/*
 * Metohod GetMax()
 * 
 * Write a method GetMax() with two parameters that returns the larger of two integers. Write a 
 * program that reads 2 integers from the console and prints the largest of them using the 
 * method GetMax().
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get max value out of two inputs.");

            Console.Write("Input your first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Input your second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int max = GetMax(firstNumber, secondNumber);
            Console.Write("Max value: ");
            Console.WriteLine(max);

            Console.ReadKey();
        }

        static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
                return firstNumber;
            else
                return secondNumber;
        }
    }
}
