using System;

namespace ConsoleApp2
{
    public class Student
    {
        public string FIO { get; set; }

        public string data { get; set; }

        public int Group { get; set; }

        public int[] Progress { get; set; }

        public Student()
        {
            FIO = "Сухушин Данила Евгеньевич";
            data = "10.01.2004";
            Group = 623;
            Progress = new int[] { 4, 5, 5, 3, 2, 2 };
        }
    }
}     
