using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AngeliA.Sprint3.Task0.V15.Lib
{
    public class Class1 : ISprint3Task0V15
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            double sinT = Math.Sin(value);

            for (int k = startValue; k <= stopValue; k++)
            {
                double term = (Math.Pow(value, k) + 2.0 / (k + 1)) * sinT;
                sum += term;
            }
            sum = Math.Round(sum, 3);
            return sum;
        }
    }
}
