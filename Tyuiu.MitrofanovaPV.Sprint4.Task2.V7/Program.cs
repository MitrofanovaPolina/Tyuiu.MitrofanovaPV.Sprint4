using Tyuiu.MitrofanovaPV.Sprint4.Task2.V7.Lib;
class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        DataService ds = new DataService();
        int len;
        len = Convert.ToInt32(Console.ReadLine());
        int[] numsArray = new int[len];
        for (int i = 0; i < len; i++)
        {
            numsArray[i] = rnd.Next(4,9);
        }
        for (int i = 0; i < len; i++)
        {
            Console.WriteLine(numsArray[i] + "\t");
        }
        int res = ds.Calculate(numsArray);
        Console.WriteLine(res);
    }
}
