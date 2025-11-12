using Tyuiu.MitrofanovaPV.Sprint4.Task7.V13.Lib;
class Program
{
    static void Main(string[] args)
    {
        int rows = 3;
        int cols = 3;
        int[,] mtrx = new int[rows, cols];
        string str = "159357246";
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int index = 0;
        Console.WriteLine("\nМассив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{str[index]} \t");
                index++;
            }
            Console.WriteLine();

        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = ds.Calculate(rows,cols,str);
        Console.WriteLine("Количество четных =" + res);
        Console.ReadKey();
    }
}