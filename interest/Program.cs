using System;

namespace interest
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter investment amount: ");
            double money = Double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter number of months: ");
            int month = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            double Interest = 0;
            for (int i = 0; i < month ; i++) {
                Interest = money * (rate/100)/12 * month;
            }
            System.Console.WriteLine($"Total interest: {Interest}");
        }
    }
}
