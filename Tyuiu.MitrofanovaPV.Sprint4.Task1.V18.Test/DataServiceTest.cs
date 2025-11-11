using Tyuiu.MitrofanovaPV.Sprint4.Task1.V18.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint4.Task1.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 1, 2, };
            int res = ds.Calculate(numsArray);
            int wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}
