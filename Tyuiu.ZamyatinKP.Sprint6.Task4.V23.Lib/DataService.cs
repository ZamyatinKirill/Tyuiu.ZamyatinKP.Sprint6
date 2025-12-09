using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZamyatinKP.Sprint6.Task4.V23.Lib
{
    public class DataService : ISprint6Task4V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] results = new double[length];

            for (int i = 0; i < length; i++)
            {
                int x = startValue + i;
                double functionValue;

                if (2 * x - 2 == 0)
                {
                    functionValue = 0;
                }
                else
                {
                    functionValue = 4 - 2 * x + (2 + Math.Cos(x)) / (2 * x + 2);
                }

                results[i] = Math.Round(functionValue, 2);
            }

            return results;
        }
    }
}
