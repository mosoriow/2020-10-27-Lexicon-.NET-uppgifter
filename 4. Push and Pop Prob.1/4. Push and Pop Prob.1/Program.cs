/*
 * Lab: Stacks
 * 1.	Reverse Strings
 * Write program that:
 *   - Reads an input string
 *   - Reverses it using a Stack<T>
 *   - Prints the result back at the terminal
 * Examples
 * Input	            Output
 * Learning Csharp	    prahsC gninraeL
 * Stacks and Queues	seueuQ dna skcatS
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Push_and_Pop_Prob._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stacks - Reverse Strings");

            Console.Write("Type a string: ");
            string inputString = Console.ReadLine();

            Stack<string> myStack = new Stack<string>();
            char[] charArray = inputString.ToCharArray(); //needed for spliting the original string

            for(int i=0;i<charArray.Length;i++)
            {
                myStack.Push(charArray[i].ToString());
            }

            Console.Write("reversed string: ");
            while (myStack.Count() > 0)
            {
                Console.Write(myStack.Pop());
            }
            Console.WriteLine();      

            Console.ReadKey();
        }
    }
}

