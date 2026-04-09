using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AngeliA.Sprint3.Task7.V6.Lib
{
    public class Class1 : ISprint3Task7V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int i = 0;
            int len = stopValue - startValue + 1;
            double[] vals = new double[len];
            for (int d = startValue; d <= stopValue; d++)
            {
                vals[i] = Math.Round((((3 * Math.Cos(d)) / (4 * d - 0.5)) + Math.Sin(d) - 5 * d - 2), 2);
                i++;
            }
            return vals;
        }
    }
}
