using System;

namespace MoneyExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            double rate = 23000;
            System.Console.WriteLine("Enter money: ");
            double money = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine($"{money} dollars is equilevent to {money*rate}VND");
        }
    }
}
