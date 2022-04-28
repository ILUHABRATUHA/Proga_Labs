using System;

namespace task_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Transport bus = new Bus("Number 17", 80, 55);

            Transport car = new Car("BMW M5", 40, false);

            car.ChangeName("Mercedes S63 AMG");

            car.View();

        }
    }
}
