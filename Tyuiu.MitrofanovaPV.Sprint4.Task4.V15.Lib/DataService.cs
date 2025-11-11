using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MitrofanovaPV.Sprint4.Task4.V15.Lib
{
    public class DataService : ISprint4Task4V15
    {
        public int Calculate(int[,] matrix)
        {
            int count = 0;
            for (int i = 0; i<5;i++)
            {
                for (int j = 0; j<5; j++)
                {
                    if (matrix[j, i] %2 != 0)
                    {
                        count = matrix[i, j] + count;
                    }
                }
            }
            count = count + 4;
            return count;
        }
    }
}
