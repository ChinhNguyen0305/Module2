using System;

namespace maxarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;

            do
            {
                System.Console.Write("Enter array's size:");
                size = Convert.ToInt32(Console.ReadLine());
                if (size > 20)
                {
                    System.Console.WriteLine("Input size under 20");
                }
            } while (size > 20);
            int i = 0;
            int[] Property = new int[size];
            while (i < size)
            {
                System.Console.WriteLine("Enter property: ");
                Property[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            for (int j = 0; j < size; j++)
            {
                System.Console.Write($"{Property[j]} \t");

            }
            System.Console.WriteLine();

            int max = Property[0];
            int index = 0;
            for (int k = 0; k < size; k++)
            {
                if (Property[k] > max)
                {
                    max = Property[k];
                    index = k;
                    
                }
            }
            System.Console.WriteLine($"Largest property is {max} at {index}");



        }
    }
}
