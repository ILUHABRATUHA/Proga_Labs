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
        public void ChangeNameTest()
        {
            Transport bus = new Bus("Number 15", 80, 30);
            bus.ChangeName("13");
            Assert.AreEqual(bus.GetName(), "13");
        }

        [TestMethod()]
        public void carChangeStatusTest()
        {
            Car car = new Car("BMW", 80, false);
            car.ChangeStatus(true);
            Assert.AreEqual(car.IsMinivan(), true);
        }

        [TestMethod()]
        public void ChangeСarNameTest()
        {
            Car bus = new Car("Number 15", 80, false);
            bus.ChangeName("13");
            Assert.AreEqual(bus.GetName(), "13 (Not minivan)");
        }

    }
}