using System;

public class Program
{
    public class Worker
    {
        private string name;
        public string aName {get{return name;}}
        
        private string surname;
        public string aSurname {get{return surname;}}
        
        private int rate;
        public int aRate {get{return rate;}}
        
        private int days;
        public int aDays {get{return days;}}

        public int GetSalary()
        {
            return rate * days;
        }

        public Worker(string name, string surname, int rate, int days)
        {
            this.name = name;
            this.surname = surname;
            this.rate = rate;
            this.days = days;
        }
    }
    static void Main()
    {
        Worker worker = new Worker("Vladislav" , "Lazarev", 980,20);
        Console.WriteLine(worker.GetSalary());
    }
}