using Microsoft.VisualStudio.TestTools.UnitTesting;
using task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Tests
{
    [TestClass()]
    public class ArithmeticTests
    {
        [TestMethod()]
        public void input_7()
        {
            int a = 7;
            double b = 7 * Math.Sin(7);

            Assert.AreEqual(b, Arithmetic.f(a));
        }

        [TestMethod()]
        public void input_10()
        {
            int a = 10;
            double b = 10 * Math.Sin(10);

            Assert.AreEqual(b, Arithmetic.f(a));
        }

        [TestMethod()]
        public void input_12_4()
        {
            int a = 12;
            int b = 4;
            double c = 4;

            Assert.AreEqual(c, Arithmetic.getMin(a, b));
        }

        [TestMethod()]
        public void input_48_48()
        {
            int a = 48;
            int b = 48;
            double c = 48;

            Assert.AreEqual(c, Arithmetic.getMin(a, b));
        }
    }
}