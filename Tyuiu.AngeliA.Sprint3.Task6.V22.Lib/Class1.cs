using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AngeliA.Sprint3.Task6.V22.Lib
{
    public class Class1 : ISprint3Task6V22
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int sum = 1;
            for (x = startValue; x <= stopValue; x++)
            {
                for (int i = 1; i * i < x; i++)
                {
                    if (x % i == 0)
                        sum = sum + 2;
                    if (i * i == x)
                        sum = sum + 1;
                }
            }
            return sum;
        }
    }
}
