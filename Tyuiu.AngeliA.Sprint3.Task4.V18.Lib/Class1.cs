using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AngeliA.Sprint3.Task4.V18.Lib
{
    public class Class1 : ISprint3Task4V18
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }
                else
                {
                    res = res + (Math.Sin(x) / Math.Cos(x));
                }

            }
            return Math.Round(res, 3);
        }
    }
}
