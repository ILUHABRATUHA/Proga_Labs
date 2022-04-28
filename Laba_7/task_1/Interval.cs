using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public class Interval
    {
        private int a = 0, b = 0;

        public Interval(int a, int b)
        {
            if (a < b)
            {
                this.a = a;
                this.b = b;
            }
            else
            {
                this.a = b;
                this.b = a;
            }
        }

        public double Start()
        {
            return a;
        }
        public double End()
        {
            return b;
        }
        public int CalculateLenght()
        {
            return b - a;
        }

        public bool isNull()
        {
            if (CalculateLenght() != 0) return true;
            else return false;
        }

        public static bool operator true(Interval other)
        {
            return other.isNull();
        }

        public static bool operator false(Interval other)
        {
            return !true;
        }
           
        public static Interval operator +(Interval other, int val)
        {
            return new Interval(other.a + val, other.b + val);
        }
        public static Interval operator -(Interval other, int val)
        {
            return new Interval(other.a - val, other.b - val);
        }
        public static Interval operator *(Interval left, Interval right)
        {
            if(right.a < left.b && right.a > left.a)
            {
                return new Interval(right.a, left.b);
            }
            else if(right.b < left.a && right.b > left.b) {
                return new Interval(right.b, left.a);
            }
            else
            {
                return new Interval(left.a, left.b);
            }
        }
        public static Interval operator ++(Interval other)
        {
            return new Interval(other.a, other.b + 1);
        }
        public static Interval operator --(Interval other)
        {
            return new Interval(other.a, other.b - 1);
        }
        public static bool operator ==(Interval left, Interval right)
        {
            return (left.a == right.a && left.b == right.b);
        }
        public static bool operator !=(Interval left, Interval right)
        {
            return (left.a != right.a || left.b != right.b);
        }

    }
}
