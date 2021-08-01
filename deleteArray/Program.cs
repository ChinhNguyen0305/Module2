using System;

namespace deleteArray
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter array's size: ");
            int size = Int32.Parse(Console.ReadLine());
            int[] newArray = new int[size];
            int i = 0;
            Random rnd = new Random();

            do
            {
                newArray[i] = rnd.Next(10, 50);
                i++;
            } while (i < size);

            System.Console.WriteLine(string.Join("-", newArray));
            int value = Convert.ToInt32(Console.ReadLine());
            bool check = false;
            int index = 0;
            for (int j = 0; j < newArray.Length; j++)
            {
                if (newArray[j] == value)
                {
                    check = true;
                    index = j;
                    break;
                }
            }
            if (check)
            {


                for (int k = index; k < newArray.Length - 1; k++)
                {
                    newArray[k] = newArray[k + 1];
                }
                Array.Resize(ref newArray, size - 1);

            }
            System.Console.WriteLine(string.Join("-", newArray));
        }
    }
}
