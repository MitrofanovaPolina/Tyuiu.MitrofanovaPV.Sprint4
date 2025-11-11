using Tyuiu.MitrofanovaPV.Sprint4.Task4.V15.Lib;
class Program
{
    static void Main(string[] args)
    {
       
        DataService ds = new DataService();
        int[,] matrix = { { 4, 2, 5, 5, 3 }, { 4, 2, 5, 2, 2 }, { 3, 6, 4, 2, 4 }, { 3, 6, 4, 5, 4 }, { 2, 4, 6, 4, 2 } };
        
        int res = ds.Calculate(matrix);
        Console.WriteLine(res);
    }
}
