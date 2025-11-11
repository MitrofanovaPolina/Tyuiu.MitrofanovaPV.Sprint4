using Tyuiu.MitrofanovaPV.Sprint4.Task5.V25.Lib;
class Program
{
    static void Main(string[] args)
    {

        DataService ds = new DataService();
        Random rnd = new Random();
        int rows = Convert.ToInt32(Console.ReadLine());
        int cols = Convert.ToInt32(Console.ReadLine());
        int[,] mtrx = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                mtrx[i, j] = rnd.Next(-4, 3);
            }
        }
        int res = ds.Calculate(mtrx);
        Console.WriteLine(res);
    }
}
