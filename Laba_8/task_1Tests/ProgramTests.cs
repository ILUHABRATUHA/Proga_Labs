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
        public void maxtest1()
        {
            Airport ex = new Airport("name");

            Assert.AreEqual(0, ex.MaxTariff());
        }

        [TestMethod()]
        public void maxTest2()
        {
            Airport ex = Airport.CreateAirport("Domodedovo");
            Tariff tariff = new Tariff("Moscow", "London", "250");
            SpecialTariff spc_tar = new SpecialTariff("Paris", "Vitebsk", "440", "30");
            ex.Add(tariff);
            ex.Add(spc_tar);

            Assert.AreEqual(308, ex.MaxTariff());
        }
  
    }
}