using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZamyatinKP.Sprint6.Task7.V18.Lib
{
    public class DataService : ISprint6Task7V18
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

            int rows = 11;
            int cols = 11;
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
  
                string[] values = lines[i].Split(new char[] { ' ', ',', ';', '\t' },
                                                StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < cols; j++)
                {
                    if (int.TryParse(values[j].Trim(), out int value))
                    {
                        matrix[i, j] = value;
                    }
                }
            }

            int columnIndex = 8;

            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, columnIndex] != 11)
                {
                    matrix[i, columnIndex] = 11;
                }
            }

            return matrix;
        }
    }
}
