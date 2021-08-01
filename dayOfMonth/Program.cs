using System;

namespace dayOfMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter month: ");
            int month = Convert.ToInt16(Console.ReadLine());

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                System.Console.WriteLine($"{month} has 31 days");
                break;
                case 4:
                case 6:
                case 9:
                case 11:
                System.Console.WriteLine($"{month}month has 30 days");
                break;
                case 2:
                System.Console.WriteLine("Feburary has 28 or 29 days");
                break;
                default:
                System.Console.WriteLine("invalid month");
                break;
            }
        }
    }
}
