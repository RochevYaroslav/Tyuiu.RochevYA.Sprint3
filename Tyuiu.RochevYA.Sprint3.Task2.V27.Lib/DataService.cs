using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RochevYA.Sprint3.Task2.V27.Lib
{
    public class DataService : ISprint3Task2V27
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sum = 0.0;

            int k = startValue;
            do
            {
                sum += Math.Pow((4/(1+Math.Pow(value,k))),k);
                k ++;
            } while (k <= stopValue);
            return Math.Round(sum,3);
        }
    }
}
