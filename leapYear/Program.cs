using System;

namespace leapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("input year:");
            int year = Convert.ToInt32(Console.ReadLine());         
           
            if (year % 100 ==0) {
                if (year % 400 ==0) {
                    System.Console.WriteLine($"{year} is leap year");
                }else {
                    System.Console.WriteLine($"{year} is not leap year");
                }
            }
             if (year % 4 == 0 ) {
                if (year % 100!=0)
                Console.WriteLine($"{year} is leap year");
            }else {
                System.Console.WriteLine($"{year} is not leap year");
            }
        }
    }
}
