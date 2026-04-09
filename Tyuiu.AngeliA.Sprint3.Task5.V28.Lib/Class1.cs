using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AngeliA.Sprint3.Task5.V28.Lib
{
    public class Class1 : ISprint3Task5V28
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumseries = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int j = startValue2; j <= stopValue2; j++)
                {
                    sumseries += (Math.Pow(j, x) / Math.Sin(j));

                }
            }
            return Math.Round(sumseries, 3);
        }
    }
}
