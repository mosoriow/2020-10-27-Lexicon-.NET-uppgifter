/*
 * Multidimensional Arrays
 * 1.	Sum Matrix Elements
 * Write program that read a matrix from console and print:
 *  - Count of rows
 *  - Count of columns
 *  - Sum of all matrix elements
 *  On first line you will get matrix sizes in format [rows, columns]
 *  
 *  Examples
 *  Input	            Output
 *  3, 6
 *  7, 1, 3, 3, 2, 1    3
 *  1, 3, 9, 8, 5, 6    6
 *  4, 6, 7, 9, 1, 0    76
 * 
 * Hints
 *  - On next [rows] lines you will get elements for each column separated with coma and whitespace
 *  - Try to use only foreach for printing
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Multidimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multidimensional Arrays");

            Console.Write("input number or rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("input number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[][] myMatrix = new int[rows][];
            for(int i=0;i<rows;i++)
            {
                myMatrix[i] = new int[cols];
            }

            for(int i=0;i<rows;i++)
            {
                for(int j=0;j<cols;j++)
                {
                    Console.Write("input mat[{0}][{1}]: ", (i + 1), (j + 1));
                    myMatrix[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("Count of rows: {0}", rows);
            Console.WriteLine("Count of columns: {0}", cols);

            int totalSum = 0;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    totalSum += myMatrix[i][j];
            Console.WriteLine("Sum of all matrix elements: {0}", totalSum);

            Console.ReadKey();
        }
    }
}
