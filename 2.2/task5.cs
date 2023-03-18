using System;

namespace ConsoleApp1
{
    public class Program
    {
        public class Default
        {
            public string name;
            public int age;

            public Default()
            {
                name = "Vladislav";
                age = 12;
            }
            public Default(string name, int age)
            {
                if (name == "Vladislav" && age == 12)
                {
                    Console.WriteLine("Условия выполнены");
                }
                else
                {
                    Console.WriteLine("Условия не выполнены");
                }
            }

            ~Default()
            {
                Console.Write("Объект удален");
            }
            
        }
        static void Main(string[] args)
        {
            Default temp = new Default();
            Default user = new Default("Sosiska", 69);
        }
    }
}