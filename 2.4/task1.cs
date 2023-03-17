using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите римское число (Например: MCMXCIV)");
            string RomeNumber = Console.ReadLine();
            string RomeNumeral = RomeNumber; 
            int result = RomeToInt(RomeNumeral);

            Console.WriteLine("Римское число: `{0}` преобразовано в целое: `{1}`", RomeNumeral, result);
        }
        static int RomeToInt(string s)
        {
            Dictionary<char, int> romanValues = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            int result = 0;
            int prevValue = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                int currentValue = romanValues[s[i]];

                if (currentValue < prevValue)
                {
                    result -= currentValue;
                }
                else
                {
                    result += currentValue; 
                }
                prevValue = currentValue;
            }
            return result;
        }
    }
}