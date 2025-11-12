using Tyuiu.MitrofanovaPV.Sprint4.Task7.V13.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint4.Task7.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 3;
            int cols = 3;
            int[,] mtrx = new int[rows, cols];
            string str = "159357246";
            DataService ds = new DataService();
            int res = ds.Calculate(rows,cols,str);
            int wait = 3;
            Assert.AreEqual(wait,res);
        }
    }
}
