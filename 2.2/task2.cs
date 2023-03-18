using System;
using System.Collections.Generic;

public class Program
{
    public class Train
    {
        private string stantion;
        public int id{get; private set;}
        private DateTime timeDepature;
        public void PrintInfo()
        {
            Console.WriteLine($"Станция - {this.stantion}\nНомер поезда - {this.id}\nВремя отправления - {this.timeDepature}");
        }
        public Train(string stantion, int id, DateTime timeDepature)
        {
            this.stantion = stantion;
            this.id = id;
            this.timeDepature = timeDepature;
        }
    }
    static void Main()
    {
        Console.WriteLine("Введите id поезда: ");
        
        List<Train> trains = new List<Train>()
        {
            new Train("Новосибирск", 1, new DateTime(year : 2023, month : 2, day : 12, hour: 11, minute : 10, second : 0)),
            new Train("Малиновка", 2, new DateTime(year : 2023, month : 3, day : 4, hour: 17, minute : 30, second : 0)),
            new Train("Тайга", 3, new DateTime(year : 2023, month : 4, day : 6, hour: 14, minute : 50, second : 0))
        };
        int _id = int.Parse(Console.ReadLine());
        foreach(Train train in trains)
        {
            if (train.id == _id)
                train.PrintInfo();
        }
    }
}