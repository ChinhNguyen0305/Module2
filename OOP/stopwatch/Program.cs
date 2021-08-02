using System;

namespace stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch mystw = new StopWatch();
            int text = 2;
            if (text == 2)
            {
                text++;
            }
            // System.Console.WriteLine("Star!");
            // mystw.Start();
            // string mystwstar = Console.ReadLine();
            // System.Console.WriteLine("Stop!");
            // mystw.Stop();
            // TimeSpan elapse = mystw.GetElapsedTime();
            // System.Console.WriteLine(elapse);
            int[] arrayA = GenerateArray(1000, 10, 300);
            mystw.Start();
            Array.Sort(arrayA);
            mystw.Stop();
            TimeSpan elapse =mystw.GetElapsedTime();
            showArray(arrayA);
            System.Console.WriteLine($"elapse time to sort 1000 value: {elapse}");
        }
        static int[] GenerateArray(int size = 10, int min = 20, int max = 90)
        {
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Random rnd = new Random();
                int random = rnd.Next(min, max);
                arr[i] = random;
            }
            return arr;
        }
        static void showArray(int[] arr)
        {

            System.Console.WriteLine(string.Join("-", arr));
            System.Console.WriteLine();
        }
    }

    class StopWatch
    {
        private DateTime startTime;
        private DateTime endTime;
        public StopWatch()
        {
            this.startTime = DateTime.Now;
        }
        public void Start()
        {
            startTime = DateTime.Now;
        }
        public void Stop()
        {
            endTime = DateTime.Now;
        }
        public TimeSpan GetElapsedTime()
        {
            TimeSpan interval = endTime - startTime;
            return interval;
        }

    }



}
