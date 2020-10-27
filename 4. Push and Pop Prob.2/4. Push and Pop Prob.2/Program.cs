/*
 * Lab: Stacks
 * Simple Calculator
 * Create a simple calculator that can evaluate simple expressions with only addition and 
 * subtraction. There will not be any parentheses.
 * Solve the problem using a Stack.
 * Examples
 *  Input	            Output
 *  2 + 5 + 10 - 2 - 1	14
 *  2 - 2 + 5	        5
 *  
 * Hints
 *  - Use a Stack<string>
 *  - You can either
 *      - add the elements and then Pop() them out
 *      - or Push() them and reverse the stack
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Push_and_Pop_Prob._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stacks - Simple Calculator");

            Console.Write("Type string expression: ");
            string expression = Console.ReadLine();

            string[] strAtoms = expression.Split(' ');

            Stack<string> myStack = new Stack<string>();
            myStack.Push("+"); // the first value is always added to the result
            for (int i = 0; i < strAtoms.Length; i++)
            {
                myStack.Push(strAtoms[i]);
            }

            int result = 0;
            int prevValue = 0;
            while (myStack.Count() > 0)
            {
                string topString = myStack.Pop();

                if (topString == "+")
                {
                    result += prevValue;
                    prevValue = 0;
                }
                else if (topString == "-")
                {
                    result -= prevValue;
                    prevValue = 0;
                }
                else
                {
                    prevValue = int.Parse(topString);
                }
            }

            Console.WriteLine("Result: {0}", result);

            Console.ReadKey();
        }
    }
}
