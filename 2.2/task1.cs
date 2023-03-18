using System;
using System.Collections.Generic;

public class Program
{
    public class Student
    {
        private string SecondName;
        private DateTime DateOfBirth;
        private int Group;
        private List<int> grades = new List<int>();
        
        public void PrintInfo()
        {
            Console.WriteLine($"Фамилия - {SecondName}\nГруппа - {Group}\nДата рождения - {DateOfBirth}");
            foreach (int grade in grades)
            {
                System.Console.Write(grade + " ");
            }
            System.Console.WriteLine();
        }
        
        public void Changeinfo(string secondName)
        {
            this.SecondName = secondName;
        }
        public void Changeinfo(string secondName, DateTime dateOfBirth)
        {
            this.SecondName = secondName;
            this.DateOfBirth = dateOfBirth;
        }
        public void Changeinfo(string secondName, DateTime dateOfBirth, int group)
        {
            this.SecondName = secondName;
            this.DateOfBirth = dateOfBirth;
            this.Group = group;
        }

        public Student(string secondName, DateTime dateOfBirth, int group, List<int> grades)
        {
            this.SecondName = secondName;
            this.DateOfBirth = dateOfBirth;
            this.Group = group;
            this.grades = grades;
        }
    }

    static void Main()
    {
        Student Vladislav = new Student("McVicky", new DateTime(1993, 05, 20), 666, new List<int> {5, 4, 4, 5, 5});
        Vladislav.Changeinfo(secondName: "Lazarev", dateOfBirth: new DateTime(2004,09,12), group: 621);
        Vladislav.PrintInfo();
    }
}