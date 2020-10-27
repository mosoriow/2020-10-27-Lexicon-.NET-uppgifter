/*
 * Streams and Files
 * Line Numbers
 * Write a program that reads a text file and inserts line numbers in front of each of its lines. 
 * The result should be written to another text file. Use StreamReader in combination with 
 * StreamWriter.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3.Streams_and_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Excersise 3 - Streams and Files");
            string inputFilePath = "D:\\tmp\\input.txt";
            string outputFilePath = "D:\\tmp\\output.txt";

            using (StreamReader inputFile = new StreamReader(inputFilePath))
            {
                using (StreamWriter outputFile = new StreamWriter(outputFilePath))
                {
                    string newLine;
                    int counter = 1;

                    while ((newLine = inputFile.ReadLine()) != null)
                    {
                        outputFile.WriteLine("Line {0}: {1}", counter, newLine);
                        counter++;
                    }

                    Console.WriteLine("Output file created at {0}", outputFilePath);
                }
            }

            Console.ReadKey();
        }
    }
}
