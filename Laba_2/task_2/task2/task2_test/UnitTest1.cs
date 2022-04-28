using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace task2_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void enter_5_1()
        {
            Program obj = new Program();

            Assert.AreEqual(obj.checkArea(5, 1), 1);


        }
        [TestMethod]
        public void enter_9_0()
        {
            Program obj = new Program();

            Assert.AreEqual(obj.checkArea(9, 0), 2);
        }
        [TestMethod]
        public void enter_9_9()
        {
            Program obj = new Program();

            Assert.AreEqual(obj.isInShape(5, 5), 0);


        }
    }
}
