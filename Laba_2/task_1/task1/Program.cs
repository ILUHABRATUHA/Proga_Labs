using System;

namespace task1
{
    public class Program
    {
        public static int isDevisible(int m, int n)
        {
            return m % n;
        }
        static void Main(string[] args)
        {
            bool answer = true;
            Console.WriteLine("Enter two numbers M and N to check divisibility of the number M by the number N");

            while (answer)
            {
                Console.WriteLine("\nEnter M:");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter N:");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n == 0)
                {
                    Console.WriteLine("\nM is not divisible by N");
                }
                else
                {

                    int c = isDevisible(m, n);

                    if (c == 0)
                    {
                        Console.WriteLine("\nDivision result is " + m / n);
                    }
                    else
                    {
                        Console.WriteLine("\nM is not divisible by N");
                    }
                }

                bool temp = false;
                do
                {
                    Console.WriteLine("\nDo you want to continue? Enter number: \n1) Continue\n2) Break: ");

                    string str = Console.ReadLine();

                    switch (Convert.ToInt32(str))
                    {
                        case 1:
                            answer = true;
                            temp = false;
                            break;
                        case 2:
                            answer = false;
                            temp = false;
                            break;
                        default:
                            temp = true;
                            break;                    
                    }
                } while (temp);

            }
            
        }
    }
}
