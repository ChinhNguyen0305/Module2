using System;

namespace minArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array = new int [5] ;
            Random rnd = new Random();
            for (int i = 0; i < 5; i++) {
                array[i] = rnd.Next(0,30);
            }
            System.Console.WriteLine(string.Join("-",array));    
            System.Console.WriteLine(MinValue(array));
        }

        static int MinValue (int [] array) {
            int min = array [0];
            int index = 0;
            for (int i = 0; i < array.Length ; i++) {
                if (array[i] <  min) {
                    min = array[i];
                    index = i;
                }
            }return min;
        }
    }
}
