using System;

namespace ConsoleApp5
{
    public class Udali
    {
        private int num1;
        private int num2;

        public int Num1
        {
            get => this.num1;
            set => this.num1 = value;
        }

        public int Num2
        {
            get => this.num2; 
            set => this.num2 = value;
        }

        public Udali(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public Udali()
        {
            this.Num1 = 1707;
            this.Num2 = 3032023;
        }



        ~Udali()
        {
            Console.WriteLine($"{Num1} has been deleted");
            Console.WriteLine($"{Num2} has been deleted");
        }
    }
}