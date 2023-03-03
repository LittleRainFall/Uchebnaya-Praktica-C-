using System;

namespace ConsoleApp4
{
    public class Counter
    {
        private int Numbers;

        public int value
        {
            get { return Numbers; }
        }

        public Counter()
        {
            Random rnd = new Random();
            this.Numbers = rnd.Next(10, 100);
        }

        public Counter(int RNDnum)
        {
            this.Numbers = RNDnum;
        }

        public void Increase()
        {
            Numbers++;
        }

        public void Decrease()
        {
            Numbers--;
        }

    }
}