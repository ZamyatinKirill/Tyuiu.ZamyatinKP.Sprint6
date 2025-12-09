using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZamyatinKP.Sprint6.Task2.V1.Lib
{
    public class DataService : ISprint6Task2V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] results = new double[length];

            for (int i = 0; i < length; i++)
            {
                int x = startValue + i;
                double functionValue;

                if (2 - 2 * x == 0)
                {
                    functionValue = 0;
                }
                else
                {
                    functionValue = Math.Cos(x) + Math.Sin(x) / (2 - 2 * x) - 4 * x;
                }

                results[i] = Math.Round(functionValue, 2);
            }

            return results;
        }
    }
}
