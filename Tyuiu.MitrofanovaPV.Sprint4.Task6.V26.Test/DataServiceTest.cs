using Tyuiu.MitrofanovaPV.Sprint4.Task6.V26.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint4.Task6.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var city = new string[] { "Тюмень", "Тамбов", "Томск", "Омск", "Орёл" };
            var res = ds.Calculate(city);
            var wait = new string[] { "Тюмень", "Тамбов" };
            Assert.AreEqual(res, wait);
        }
    }
}
