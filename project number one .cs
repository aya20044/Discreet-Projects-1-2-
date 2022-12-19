// See https://aka.ms/new-console-template for more information
// converion using casting operation
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System;
namespace Projectone
{
    class project1
    {
        static void Main(string[] args)
        { // project one discreet task // prime numbers //start

            double i = 0, j = 0;
            Console.WriteLine("enter the first number,please");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number,please");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("\n");
            if (num1+num2<0 && num2<num1) { Console.Write(" invalid operation prime numbers are greater than 1"); }
            for (i = num1; i <= num2; i++)
            { 
                if (i + num2<0) { Console.Write(" invalid operation prime numbers are greater than 1"); break; }
                if (i == 0 || i == 1)
                    continue;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0) break;
                    if (i % j != 0) ;

                }
                if (i == j) Console.WriteLine(i);
            } 
            if (i > 2) Console.WriteLine("The list of your prime numbers.");
            Console.ReadLine();
        }
    }
}
//End 
