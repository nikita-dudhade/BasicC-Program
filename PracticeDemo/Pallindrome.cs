//Find out if the given number is palindrome or not.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDemo
{
    internal class Pallindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            int temp = num;
            int sum = 0;
           while(num>0)
            {
                int rem = num % 10;
                sum = sum * 10 + rem;
                num = num / 10;
            }
           if(temp==sum)
                Console.WriteLine("Number is  Pallindrome");
            else
                Console.WriteLine("Number is not Pallindrome");
        }
    }
}
