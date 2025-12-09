using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZamyatinKP.Sprint6.Task7.V18.Lib
{
    public class DataService : ISprint6Task7V18
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

            int rows = lines.Length;

            string[] firstLineValues = lines[0].Split(new char[] { ' ', ',', ';', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int cols = firstLineValues.Length;

            for (int i = 1; i < rows; i++)
            {
                string[] currentValues = lines[i].Split(new char[] { ' ', ',', ';', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (currentValues.Length != cols)
                {
                    throw new FormatException($"Строка {i + 1} содержит {currentValues.Length} значений, ожидалось {cols}");
                }
            }

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(new char[] { ' ', ',', ';', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < cols; j++)
                {
                    if (int.TryParse(values[j].Trim(), out int value))
                    {
                        matrix[i, j] = value;
                    }
                    else
                    {
                        throw new FormatException($"Неверный формат числа в строке {i + 1}, столбце {j + 1}: '{values[j]}'");
                    }
                }
            }


            if (cols > 8)
            {
                int columnIndex = 8;

                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, columnIndex] != 11)
                    {
                        matrix[i, columnIndex] = 11;
                    }
                }
            }

            return matrix;
        }
    }
}
