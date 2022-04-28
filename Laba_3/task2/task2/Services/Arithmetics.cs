using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.Services
{
    public class Arithmetics
    {
        public static double getResult(double z, double b)
        {
            double x;

            if(z < 1)
            {
                x = z / (double)b;
            }
            else
            {
                x = Math.Sqrt(Math.Pow(z * b, 3));
            }

            return -Math.PI + Math.Pow(Math.Cos(Math.Pow(x, 3)), 2) + Math.Pow(Math.Sin(Math.Pow(x, 2)), 3);
        }
    }
}
