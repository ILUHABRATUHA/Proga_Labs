using System;

namespace task_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Interval example = new Interval(1, 10);

            Console.WriteLine("Start of interval: " + example.Start());
            Console.WriteLine("End of interval: " + example.End());
            Console.WriteLine("Lenght: " + example.CalculateLenght());
            example++;
            Console.WriteLine("++: " + example.CalculateLenght());
            example--;
            Console.WriteLine("--: " + example.CalculateLenght());

        }
    }
}
