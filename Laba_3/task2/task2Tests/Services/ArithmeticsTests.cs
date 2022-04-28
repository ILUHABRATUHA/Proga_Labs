using Microsoft.VisualStudio.TestTools.UnitTesting;
using task2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.Services.Tests
{
    [TestClass()]
    public class ArithmeticsTests
    {
        [TestMethod()]
        public void input_05_005()
        {
            double a = 0.5;
            double b = 0.05; 
            double c = -2.955157698997241;

            Assert.AreEqual(c, Arithmetics.getResult(a, b));
        }

        [TestMethod()]
        public void input_10_20()
        {
            double a = 10;
            double b = 20;
            double c = -2.684449460575381;

            Assert.AreEqual(c, Arithmetics.getResult(a, b));
        }
    }
}