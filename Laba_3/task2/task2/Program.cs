using System;
using task2.Services;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Z and B to get result of expression");

            Console.WriteLine("\nEnter Z:");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter B:");
            double b = Convert.ToDouble(Console.ReadLine());

            double result = Arithmetics.getResult(z, b);

            if(z < 1)
            {
                Console.WriteLine("\nCase №1.\nResult: " + result);
            } 
            else
            {
                Console.WriteLine("\nCase №2.\nResult: " + result);
            }
        }
    }
}
