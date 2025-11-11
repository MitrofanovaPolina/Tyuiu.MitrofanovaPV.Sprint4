using Tyuiu.MitrofanovaPV.Sprint4.Task0.V21.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        int[] numsArray = { 8, 2, 4, 3, 8, 5, 6, 7, 9, 8 };
        int res = ds.GetSumEvenArrEl(numsArray);
        Console.WriteLine(res);
    }
}
