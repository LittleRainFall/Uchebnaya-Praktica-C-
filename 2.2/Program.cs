using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            int pon = 0;
            {
                Console.WriteLine("Выберете нужный пункт: \n" +
                                  "1 - Просмотр информации о студенте. \n" +
                                  "2 - Изменить ФИО. \n" +
                                  "3 - Изменить дату рождения. \n" +
                                  "4 - Изменить группу. \n" +
                                  "5 - Выйти из меню.");
                while (pon != 5)
                {
                    pon = Convert.ToInt32(Console.ReadLine());
                    if (pon == 5)
                    {
                        break;
                        ;
                    }


                    switch (pon)
                    {
                        case 1:
                        {
                            Console.WriteLine($"ФИО: {stud.FIO}");
                            Console.WriteLine($"Дата рождения: {stud.data}");
                            Console.WriteLine($"Группа: {stud.Group}");
                            Console.WriteLine($"Оценки: ");
                            foreach (var process in stud.Progress)
                            {
                                Console.WriteLine($"{process} ");
                            }


                            Console.WriteLine(" ");
                            break;
                        }
                        case 2:
                        {
                            Console.WriteLine("Введите ФИО студента: ");
                            stud.FIO = Console.ReadLine();
                            Console.WriteLine($"Новое ФИО студента: {stud.FIO}");
                            break;
                        }

                        case 3:
                        {
                            Console.WriteLine("Введите дату рождения: ");
                            stud.data = Console.ReadLine();
                            Console.WriteLine($"Новая дата рождения: {stud.data}");
                            break;
                        }
                        case 4:
                        {
                            Console.WriteLine("Введите группу: ");
                            stud.Group = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Новая группа: {stud.Group}");
                            break;

                        }
                    }
                }
            }
        }
    }
}