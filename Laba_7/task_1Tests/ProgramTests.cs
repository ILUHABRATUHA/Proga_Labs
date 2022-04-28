using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void LengthTest1()
        {
            Interval a = new Interval(12, 12);
            Assert.AreEqual(0, a.CalculateLenght());
        }

        [TestMethod()]
        public void LengthTest2()
        {
            Interval a = new Interval(1, 100);
            Assert.AreEqual(99, a.CalculateLenght());
        }

        [TestMethod()]
        public void IntrsctTest()
        {
            Interval a = new Interval(1, 100);
            Interval b = new Interval(90, 110);
            Assert.AreEqual(10, (a * b).CalculateLenght());
        }

        [TestMethod()]
        public void OperationsTest1()
        {
            Interval a = new Interval(1, 100);
            
            for(int i = 0; i < 11; i++)
            {
                a++;
            }
            a--;
            Assert.AreEqual(109, a.CalculateLenght());
        }

        [TestMethod()]
        public void OperationsTest2()
        {
            Interval a = new Interval(1, 100);

            a += 5;
            a -= 1;
            
            Assert.AreEqual(5, a.Start());
        }

        [TestMethod()]
        public void isNullTest1()
        {
            Interval a = new Interval(1, 1);

            Assert.AreEqual(false, a.isNull());
        }

        [TestMethod()]
        public void isNullTest2()
        {
            Interval a = new Interval(1, 100);

            Assert.AreEqual(true, a.isNull());
        }
    }
}