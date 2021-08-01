using System;

namespace addingValue
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter array's size:");
            int size = Convert.ToInt32(System.Console.ReadLine());

            int[] arrayA = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                arrayA[i] = rnd.Next(10, 30);

            }
            showArray(arrayA);
            System.Console.Write("Enter value:");
            int value = Int32.Parse(Console.ReadLine());
            System.Console.Write("Enter position:");
            int index = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref arrayA, size + 1);
            for (int i = size; i >= index; i--)
            {
                arrayA[i] = arrayA[i - 1];

            }
            arrayA[index] = value;

            showArray(arrayA);
        }
        static void showArray(int[] array)
        {
            for (int k = 0; k < array.Length; k++)
            {
                System.Console.Write($"{array[k]} ");

            }
            System.Console.WriteLine();
        }
    }
}
