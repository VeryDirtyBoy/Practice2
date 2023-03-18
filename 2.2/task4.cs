using System;

public class Program
{
    public class Counter
    {
        private int counter;

        public void Show()
        {
            Console.WriteLine(counter);
        }
        
        public void Increase()
        {
            counter++;
        }
        public void Decrease()
        {
            counter--;
        }

        public Counter()
        {
            counter = 0;
        }

        public Counter(int num)
        {
            counter = num;
        }
    }

    static void Main()
    {
        Counter counter = new Counter(12);
        counter.Show();
        counter.Increase();
        counter.Show();

        Counter counter1 = new Counter(10);
        counter1.Show();
        counter1.Decrease();
        counter1.Show();
    }
}