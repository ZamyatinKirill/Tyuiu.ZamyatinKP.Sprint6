using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZamyatinKP.Sprint6.Task3.V25.Lib
{
    public class DataService : ISprint6Task3V25
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[,] result = (int[,])matrix.Clone();

            int[][] rows = new int[5][];
            for (int i = 0; i < 5; i++)
            {
                rows[i] = new int[5];
                for (int j = 0; j < 5; j++)
                {
                    rows[i][j] = result[i, j];
                }
            }

            Array.Sort(rows, (row1, row2) => row1[2].CompareTo(row2[2]));

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    result[i, j] = rows[i][j];
                }
            }

            return result;

        }
    }
}
