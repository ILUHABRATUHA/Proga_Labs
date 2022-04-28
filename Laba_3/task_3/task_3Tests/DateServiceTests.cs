using Microsoft.VisualStudio.TestTools.UnitTesting;
using task_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3.Tests
{
    [TestClass()]
    public class DateServiceTests
    {
        [TestMethod()]
        public void GetDateTest()
        {
            DateOnly currDay = new(2022, 4, 27);
            int a = Math.Abs(DateOnly.Parse(DateTime.Today.ToShortDateString()).DayNumber - currDay.DayNumber);

            Assert.AreEqual(a, DateService.GetDaysSpan(currDay));
        }
    }
}