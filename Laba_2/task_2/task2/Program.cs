using System;

namespace task2
{

    class Program
    {

        public static int checkArea(int x, int y)
        {
            if ((x >= 0) && (Math.Pow(x, 2) + Math.Pow(y, 2) < 81))
            {
                return 1;
            }
            else if ((x >= 0) && (Math.Pow(x, 2) + Math.Pow(y, 2) == 81))
            {
                return 2;
            } else
            {
                return 0;
            }

        }
        static void Main(string[] args)
        {

            bool answer = true;

            while (answer)
            {
                Console.WriteLine("\nEnter x: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter y: ");
                int y = Convert.ToInt32(Console.ReadLine());

                switch(checkArea(x,y))
                {
                    case 1:
                        Console.WriteLine("\nYes");
                        break;
                    case 2:
                        Console.WriteLine("\nOn the border");
                        break;
                    default:
                        Console.WriteLine("\nNo");
                        break;

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
