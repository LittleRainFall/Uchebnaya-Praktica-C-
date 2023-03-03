using System;

namespace ConsoleApp5
{
    class Program
    {
        public static void Method()
        {
            Udali Chebypelya = new Udali();
        }
        static void Main(string[] args)
        {


            Method();

            GC.Collect();
            Console.ReadLine();



        }
    }
}