using Tyuiu.MitrofanovaPV.Sprint4.Task3.V11.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint4.Task3.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[3,3] { { 1,2,3}, {4,5,6}, {7,8,9} };
            int res = ds.Calculate(mas2 );
            int wait = 1;
            Assert.AreEqual( wait, res );
        }
    }
}
