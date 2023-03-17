using System;

namespace ConsoleApplication1
{
    public class Worker
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int rate { get; set; }
        public int days { get; set; }
        public int GetSalary()
        {
            return rate * days;
        }
    }
    public class Program 
    {
        public static void Main(string[] args)
        {
            Worker worker = new Worker();
            Console.WriteLine("Введите имя:");
            worker.name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            worker.surname = Console.ReadLine();
            Console.WriteLine("Введите ставку:");
            worker.rate = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во дней:");
            worker.days = int.Parse(Console.ReadLine());
            Console.WriteLine("Работник: {0} {1} \nЗарплата: {2} рублей", worker.name, worker.surname, worker.GetSalary());
        }
    }
}