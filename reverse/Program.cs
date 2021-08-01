using System;

namespace reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            int[] array;
            do
            {
                System.Console.WriteLine("Enter array's size: ");
                size = Convert.ToInt32(Console.ReadLine());
                if (size > 20)
                {
                    System.Console.WriteLine("Invalid");
                }
            } while (size > 20);
            array = new int[size];

            for (int i = 0; i < size; i++)
            {
                int temp = Convert.ToInt32(Console.ReadLine());
                if (temp != 0)
                {
                    array[i] = temp;
                }
                else
                {
                    System.Console.WriteLine("invalid value");
                }
            }
            System.Console.Write(String.Join("-", array));

            System.Console.WriteLine();

            for (int j = 0; j < array.Length/2; j++)
            {
                int temp = array[j];
                array[j] = array[array.Length - 1-j];
                array[array.Length - 1-j] = temp;
            }
            System.Console.WriteLine("Reverse Array");
            for (int j = 0; j < array.Length; j++)
            {
                System.Console.Write($"{array[j]} ");
            }
            System.Console.WriteLine();
            // System.Console.WriteLine(String.Join("-",array));;

        }

    }
}
