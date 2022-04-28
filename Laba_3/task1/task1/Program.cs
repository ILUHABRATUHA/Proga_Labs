using System;

namespace task1
{
    public class Program
    {     
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two coordinates A and B to check at which of these points the value of the function x*sin(x) is less.");

            Console.WriteLine("\nEnter A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B:");
            int b = Convert.ToInt32(Console.ReadLine());

            if(Arithmetic.f(a) < Arithmetic.f(b))
            {
                Console.WriteLine("\nIn point A value of the function is less. (" + Arithmetic.f(a) + " < " + Arithmetic.f(b) + ")");
            } 
            else if (a == b)
            {
                Console.WriteLine("\nThe values at these points are the same. (" + Arithmetic.f(a) + " == " + Arithmetic.f(b) + ")");
            }
            else
            {
                Console.WriteLine("\nIn point B value of the function is less. (" + Arithmetic.f(b) + " < " + Arithmetic.f(a) + ")");
            }
        }
    }
}
