using Microsoft.VisualStudio.TestTools.UnitTesting;
using task_1;
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
        public void valuesTets1()
        {
            Bank bank = new();

            bank.AddClient("Ilya", 1000, 20);            
            bank.AddClient("Pasha", 500, 5);

            Assert.AreEqual(225, bank.getPayments());
        }

        [TestMethod()]
        public void valuesTets2()
        {
            Bank bank = new();

            bank.AddClient("Ilya", 1000, 20);
            bank.AddClient("Pasha", 500, 5);
            bank.AddClient("Andrey", 500, 13);
            bank.AddClient("Engeniy", 1, 100);

            Assert.AreEqual(291, bank.getPayments());
        }

        [TestMethod()]
        public void percentsTest1()
        {
            Bank bank = new();

            bank.AddClient("Ilya", 1000, 20);

            Assert.AreEqual(200, bank.getPercent(0));
        }

        [TestMethod()]
        public void percentsTest2()
        {
            Bank bank = new();

            bank.AddClient("Ilya", 1000, 0);

            Assert.AreEqual(0, bank.getPercent(0));
        }
    }
}