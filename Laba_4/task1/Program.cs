using System;

namespace task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ZHES zhes = ZHES.getInstance();
            
            Console.WriteLine("Enter information about ZHES: ");

            Console.WriteLine("\nEnter your district: ");
            zhes.District = Console.ReadLine();

            Console.WriteLine("Enter number of your ZHES ");
            zhes.Number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter amount of citizens: ");
            zhes.CitizensAmount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of citizens who has already paid : ");
            zhes.NumberOFPaid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter tariff: ");
            zhes.Tariff.Price = Convert.ToInt32(Console.ReadLine());

            int debt = zhes.calculateDebt();
            Console.WriteLine("\nDebt is " + debt);
           
        }
    }
}
