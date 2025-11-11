using Tyuiu.MitrofanovaPV.Sprint4.Task4.V15.Lib;
class Program
{
    static void Main(string[] args)
    {
       
        DataService ds = new DataService();
        int rows = Convert.ToInt32(Console.ReadLine());
        int columns = Convert.ToInt32(Console.ReadLine());
        int[,] mtrx = new int [rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                mtrx[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{mtrx[i,j]} \t");
            }
        }
        int res = ds.Calculate(mtrx);
        Console.WriteLine(res);
    }
}
