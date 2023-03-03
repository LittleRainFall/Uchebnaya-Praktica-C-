using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            String j = Console.ReadLine();
            String s = Console.ReadLine();

            int otvet = 0;

            foreach (char ch in s)
            {
                if (j.IndexOf(ch) >= 0)
                {
                    otvet++;
                }  
            }
            Console.WriteLine(otvet);
        }
    }
}