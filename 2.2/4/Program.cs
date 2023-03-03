using System;

namespace ConsoleApp4
{
    public class Program
        {
            static void Main(string[] args)
            {
                Counter chislo = new Counter();
                Console.WriteLine("1 - прибавить; 2 - убавить; 3 - выход.");
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine($"(+) -- прибавить");
                        for (int i = 0; i < 100; i++)
                        {
                            string s = Console.ReadLine();
                            if (s == "+")
                            {
                                chislo.Increase();
                                int res = chislo.value;
                                Console.WriteLine(res);
                            }
                            else if (s == "")
                            {
                                break;  
                            }
                        }
                        Console.WriteLine("Выполнено");
                        break;
                    case 2:
                        Console.WriteLine($"(-) -- убавить");
                        for (int i = 0; i < 100; i++)
                        {
                            string s = Console.ReadLine();
                            if (s == "-")
                            {
                                chislo.Decrease();
                                int res = chislo.value;
                                Console.WriteLine(res);
                            }else if (s == "") 
                            {
                                break;
                            }
                        }
                        Console.WriteLine("Выполнено");
                        break;
                    case 3:
                        break;

                }
            }
    }
}