using System;

namespace ConsoleApp6
{
    public class Worker
    {
        public string name;
        public string surname;
        public int rate;
        public int day;
    
        private string Name
        {
            get => this.name;
            set => this.name = value;
        }

        private string Surname
        {
            get => this.surname;
            set => this.surname = value;
        }

        private int Rate
        {
            get => this.rate;
            set => this.rate = value;
        }

        private int Day
        {
            get => this.day;
            set => this.day = value;
        }

        public Worker()
        {
            this.Name = "Danila";
            this.Surname = "Sukhushin";
            this.Rate = 2190;
            this.Day = 23;
        }

        public void Sasha()
        {
            Console.WriteLine($"Зарплата сотрудника {name} {surname} составляет {rate*day}");
        }
    }
}