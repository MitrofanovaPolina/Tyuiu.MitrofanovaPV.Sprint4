using Tyuiu.MitrofanovaPV.Sprint4.Task2.V7.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint4.Task2.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 1, 2, 3 };
            int res = ds.Calculate(numsArray);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
