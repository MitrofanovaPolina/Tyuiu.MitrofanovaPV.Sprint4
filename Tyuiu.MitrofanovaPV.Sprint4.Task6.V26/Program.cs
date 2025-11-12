using Tyuiu.MitrofanovaPV.Sprint4.Task6.V26.Lib;
class Program
{
    static void Main (string[] args)
    {
        DataService ds = new DataService();
        var city = new string[] { "Тюмень", "Тамбов", "Томск", "Омск", "Орёл" };
        var town = ds.Calculate(city);
        for (int i = 0; i < town.Length; i++)
        {
            Console.WriteLine(town[i]);
        }
    }
}
