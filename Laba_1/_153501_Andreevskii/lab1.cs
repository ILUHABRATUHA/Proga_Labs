using System;

namespace _153501_Andreevskii
{
    class lab1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers to find the quotient of their division: ");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            double c = a / (double)b;

            Console.WriteLine("\nResult is " + c);
        }
    }
}
