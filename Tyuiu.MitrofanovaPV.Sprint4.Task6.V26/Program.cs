using Tyuiu.MitrofanovaPV.Sprint4.Task6.V26.Lib;
class Program
{
    static void Main(string[] args)
    {

        DataService ds = new DataService();
        var town = new string[] { "Тюмень", "Тамбов", "Томск", "Омск", "Орёл" };
        var nums = ds.Calculate(town);
        Console.WriteLine(nums);


    }
}