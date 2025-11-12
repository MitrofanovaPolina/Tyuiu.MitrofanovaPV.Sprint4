using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MitrofanovaPV.Sprint4.Task6.V26.Lib
{
    public class DataService : ISprint4Task6V26
    {
        public string[] Calculate(string[] array)
        {
            string[] cities = Array.FindAll(array, x => x.Length == 6);
            return cities;
        }
    }
}
