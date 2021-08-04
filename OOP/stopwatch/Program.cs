using System;

namespace stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch mystw = new StopWatch();
            
            System.Console.WriteLine("Press enter to star!");
            Console.ReadLine();
            mystw.Start();
            System.Console.WriteLine("Press enter to stop!");
            Console.ReadLine();
            System.Console.WriteLine("Stop!");
            mystw.Stop();
            TimeSpan elapse = mystw.GetElapsedTime();
            System.Console.WriteLine(elapse);
            // int[] arrayA = GenerateArray(1000, 10, 300);
            // mystw.Start();
            // Array.Sort(arrayA);
            // mystw.Stop();
            // TimeSpan elapse =mystw.GetElapsedTime();
            // showArray(arrayA);
            // System.Console.WriteLine($"elapse time to sort 1000 value: {elapse}");
        }
        public int[] GenerateArray(int size = 10, int min = 20, int max = 90)
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
