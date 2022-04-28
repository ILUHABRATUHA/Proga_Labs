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
    public class ZHESTests
    {
        [TestMethod()]
        public void input_148()
        {
            ZHES zhes = ZHES.getInstance();
            zhes.CitizensAmount = 148;
            zhes.NumberOFPaid = 100;
            zhes.Tariff.Price = 2;
            int res = 96;

            Assert.AreEqual(res, zhes.calculateDebt());
        }

        [TestMethod()]
        public void input_150()
        {
            ZHES zhes = ZHES.getInstance();
            zhes.CitizensAmount = 150;
            zhes.NumberOFPaid = 150;
            zhes.Tariff.Price = 2;
            int res = 0;

            Assert.AreEqual(res, zhes.calculateDebt());
        }
    }
}