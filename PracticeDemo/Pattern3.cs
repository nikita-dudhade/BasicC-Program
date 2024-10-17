/*
 1 
121 
12321 
1234321 
123454321 
1234321 
12321 
121 
1 

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDemo
{
    internal class Pattern3
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int row = 1; row <= 5; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                   
                    Console.Write(col);
                }
                for (int col = row - 1; col >= 1; col--)
                {
                    Console.Write(col);
                }
                Console.WriteLine();
            }
            for (int row = n-1; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
                {

                    Console.Write(col);
                }
                for (int col = row - 1; col >= 1; col--)
                {
                    Console.Write(col);
                }
                Console.WriteLine();
            }
        }
    }
}
