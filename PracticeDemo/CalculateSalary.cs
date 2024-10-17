//Write a C# program to input basic salary of an employee and calculate its  
//Gross salary according to following: Basic Salary <= 10000 : HRA = 20 %, DA = 80 % Basic Salary <= 20000 : HRA = 25 %, 
//DA = 90 % Basic Salary > 20000 : HRA = 30 %, DA = 95 %


using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDemo
{
    internal class CalculateSalary
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter Your Salary");
        //    int sal = Convert.ToInt32(Console.ReadLine());
        //    int hra = 0;
        //    int da = 0;

        //    int grosssal = 0;
        //    if(sal <=10000)
        //    {
        //        hra = sal * 20 / 100;
        //        Console.WriteLine("HRA is: " + hra);
        //        da = sal * 80 / 100;
        //        Console.WriteLine("DA is: " + da);
        //    }
        //    else if(sal<=20000)
        //        {
        //            hra = sal * 25 / 100;
        //        Console.WriteLine("HRA is: " + hra);
        //        da = sal * 90 / 100;
        //        Console.WriteLine("DA is: " + da);
        //    }
            
        //    else
        //    {
        //        hra = sal * 30 / 100;
        //        Console.WriteLine("HRA is: " + hra);
        //        da = sal * 95 / 100;
        //        Console.WriteLine("DA is: " + da);
        //    }

        //    grosssal = sal + hra + da;
        //    Console.WriteLine("Gross Salary Of Employee is :" + grosssal);
        //}
    }
}
