using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RochevYA.Sprint3.Task7.V30.Lib
{
    public class DataService : ISprint3Task7V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] results = new double[length];

            for (int x = startValue, i = 0; x <= stopValue; x++, i++)
            {
                double res = Math.Sin(x) + 2;

                if (res==0) // проверка деления на ноль
                {
                    results[i] = 0;
                }
                else
                {
                    double value = ((5 * x + 2.5) / res) + 2 * x + 2;
                    results[i] = Math.Round(value, 2);
                }
            }

            return results;
        }
    }
}
