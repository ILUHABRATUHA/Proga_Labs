using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Arithmetic
    {
        public static double f(int x)
        {
            return x * Math.Sin(x);
        }

        public static double getMin(double x, double y)
        {
            if (x < y) return x;
            else return y;
        }
    }
}
