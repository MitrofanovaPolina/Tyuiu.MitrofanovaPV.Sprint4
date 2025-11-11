using Tyuiu.MitrofanovaPV.Sprint4.Task5.V25.Lib;
class Program
{
    static void Main(string[] args)
    {

        DataService ds = new DataService();
        Random rnd = new Random();
        int rows = Convert.ToInt32(Console.ReadLine());
        int cols = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = rnd.Next(1, 3);
            }
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
        }
        int res = ds.Calculate(matrix);
        Console.WriteLine(res);

    }
}