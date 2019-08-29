using Microsoft.VisualStudio.TestTools.UnitTesting;
using UniTest;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        private Caculator cal = new Caculator();
        [TestMethod]
        public void AddTest()
        {
            Assert.IsTrue(cal.Add(1, 1) == 2);
            Assert.IsTrue(cal.Add(2, 2) == 4);
            Assert.IsTrue(cal.Add(2, 3) == 5);
            Assert.IsTrue(cal.Add(2, 'a') == 99);
        }
        [TestMethod]
        public void Subtract()
        {
            Assert.IsTrue(cal.Subtract(1, 1) == 0);
            Assert.IsTrue(cal.Subtract(9, 2) == 7);
            Assert.IsTrue(cal.Subtract(2, 3) == -1);
            Assert.IsTrue(cal.Subtract(2, 'a') == -95);
        }
    }
}
