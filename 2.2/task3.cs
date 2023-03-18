using System;

public class Program
{
    public class Nums
    {
        private int a;
        private int b;

        public void ConsoleWriteLine()
        {
            Console.WriteLine($"Первое число: {a}, второе число: {b}");
        }

        public void Variation(int first, int second)
        {
            this.a = first;
            this.b = second;
        }

        public int Sum()
        {
            return a + b;
        }

        public int Bigger()
        {
            return a > b ? a : b;
        }
        
        public Nums(int first, int second)
        {
            this.a = first;
            this.b = second;
        }
    }

    static void Main()
    {
        Nums numbers = new Nums(107, 12);
        numbers.ConsoleWriteLine();
        Console.WriteLine($"Сумма: {numbers.Sum()}");
        Console.WriteLine($"Наибольшее значение: {numbers.Bigger()}");
        numbers.Variation(45, 12);
        numbers.ConsoleWriteLine();
    }
}