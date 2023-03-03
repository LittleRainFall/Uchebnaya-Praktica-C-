using System;
using System.Collections.Generic;


namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Train> train = new List<Train>();
            train.Add(new Train("Moskov", 8, "14.04.06"));
            train.Add(new Train("Vladivostok", 19, "21.08.11"));

            int enter = 0;
            Console.WriteLine("\nВведите номер поезда или \"1\" для выхода\n");

            while (enter != 1)
            {
                string space = "";
                enter = Convert.ToInt32(Console.ReadLine());
                if (enter == 1) break;
                foreach (Train numTrain in train)
                {
                    if (numTrain.GetNumber == enter)
                    {
                        space = numTrain.ShowTrain();
                        break;
                    }
                }

                if (space != "")
                {
                    Console.WriteLine(space);
                }
                else
                {
                    Console.WriteLine("Такого поезда нет");
                }

            }
        }

    }
}