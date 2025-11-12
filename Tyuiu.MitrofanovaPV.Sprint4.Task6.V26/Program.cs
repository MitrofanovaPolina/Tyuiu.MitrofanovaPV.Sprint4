using Tyuiu.MitrofanovaPV.Sprint4.Task6.V26.Lib;
class Program
{
    static void Main(string[] args)
    {

        DataService ds = new DataService();
        string[] data = { "Тюмень", "Тамбов", "Томск", "Омск", "Орёл" };
        foreach (string item in data)
        {
            if (item.Length >5)
            {
                Console.WriteLine(item);
            }
        }


    }
}