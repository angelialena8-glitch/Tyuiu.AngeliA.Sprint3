using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AngeliA.Sprint3.Task3.V1.Lib
{
    public class Class1 : ISprint3Task3V1
    {
        public int GetCharCount(string value, char item)
        {
            if (string.IsNullOrEmpty(value))
                return 0;

            int count = 0;

            // Использование цикла foreach для подсчёта символов
            foreach (char c in value)
            {
                if (c == item)
                    count++;
            }

            return count;
        }
    }
}
