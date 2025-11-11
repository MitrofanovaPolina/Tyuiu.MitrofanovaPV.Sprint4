using Tyuiu.MitrofanovaPV.Sprint4.Task1.V18.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        int len;
        len = Convert.ToInt32(Console.ReadLine());
        int[]numsArray = new int[len];
        for (int i = 0; i < len; i++)
        {
            numsArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0;i < len ; i++)
        {
            Console.WriteLine(numsArray[i] + "\t");
        }
        int res = ds.Calculate(numsArray);
        Console.WriteLine(res);
    }
}
