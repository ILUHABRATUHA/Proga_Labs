using System;

namespace task_3
{
    public class Program
    {
        public static void Main(string[] args)
        {

            DateOnly date = DateService.GetDate();

            Console.WriteLine(DateService.DayOfWeek(date));
            Console.WriteLine(DateService.GetDaysSpan(date));
        }
    }
}
