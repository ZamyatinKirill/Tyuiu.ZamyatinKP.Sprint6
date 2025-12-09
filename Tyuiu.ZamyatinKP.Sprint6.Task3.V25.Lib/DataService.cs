using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZamyatinKP.Sprint6.Task3.V25.Lib
{
    public class DataService : ISprint6Task3V25
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[,] result = (int[,])matrix.Clone();

            int[] thirdColumn = new int[5];
            for (int i = 0; i < 5; i++)
            {
                thirdColumn[i] = result[i, 2];
            }

            Array.Sort(thirdColumn);

            for (int i = 0; i < 5; i++)
            {
                result[i, 2] = thirdColumn[i];
            }

            return result;
        }
    }
}
