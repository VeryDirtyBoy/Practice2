using System;

namespace Practice_2._1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите драгоценности (J): ");
            string J = Console.ReadLine();
            Console.WriteLine("Введите камни (S): ");
            string S = Console.ReadLine();

            var jArray = J.ToCharArray();
            var sArray = S.ToCharArray();
            int count = 0;
            for (int i = 0; i < jArray.Length; i++)
            {
                for (int j = 0; j < sArray.Length; j++)
                {
                    if (sArray[j] == jArray[i])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Кол-во символов из S входящие в J: {count}");

        }
    }
}