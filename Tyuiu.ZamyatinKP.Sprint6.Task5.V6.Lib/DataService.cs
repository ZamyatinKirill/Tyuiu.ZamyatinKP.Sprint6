using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZamyatinKP.Sprint6.Task5.V6.Lib
{
    public class DataService : ISprint6Task5V6
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            List<double> multiplesOfThree = new List<double>();

            foreach (string line in lines)
            {
                string[] tokens = line.Split(new[] { ' ', '\t', ',', ';' },
                    StringSplitOptions.RemoveEmptyEntries);

                foreach (string token in tokens)
                {
                    if (double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                    {

                        double roundedNumber = Math.Round(number, 3);

                        double remainder = Math.Abs(number % 3);
                        bool isMultipleOfThree = remainder < 0.001 || Math.Abs(remainder - 3) < 0.001;

                        if (isMultipleOfThree)
                        {
                            multiplesOfThree.Add(number);
                        }
                    }
                }
            }

            return multiplesOfThree.ToArray();
        }
    }
}
