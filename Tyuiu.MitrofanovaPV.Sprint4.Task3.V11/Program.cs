using Tyuiu.MitrofanovaPV.Sprint4.Task3.V11.Lib;
class Program
{
    static void Main(string[] args)
    {
        int[,] mtrx = new int[5, 5] { { 8, 6, 9, 4, 5 }, { 9, 4, 8, 5, 6 }, { 9, 7, 9, 8, 4 }, { 4, 6, 5, 7, 8 }, { 6, 6, 7, 6, 4 } };
        DataService ds = new DataService();
        for (int i = 0; i < mtrx.GetLength(0); i++)
        {
            for (int j = 0; j < mtrx.GetLength(1); j++)
            {
                Console.WriteLine($"{mtrx[i,j]} \t");
            }
        }
        int res = ds.Calculate(mtrx);
        Console.WriteLine(res);
    }
}

