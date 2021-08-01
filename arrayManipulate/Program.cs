using System;

namespace arrayManipulate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[4]);

            int total = 0;

            for (int i = 0; i < numbers.Length; i++) {
                total += numbers[i];
            } 
            System.Console.WriteLine($"Total of numbers: {total}");
        }

    }
}
