using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("1.Fahrenheit to Celsius");
            System.Console.WriteLine("2.Celsius to Fahrenheit");
            System.Console.WriteLine("3.Exit");
            System.Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter temperature: ");
            int temp = Convert.ToInt32(Console.ReadLine());
            double result = 0;

            switch (choice)
            {
                case 1:
                    result = FtoC(temp);
                    System.Console.WriteLine($"{temp} degree Farenheit equilevent to {result} in Celcius");

                    break;
                case 2:
                    result = CtoF(temp);
                    System.Console.WriteLine($"{temp} degree celcius equilevent to {result} in Fahrenheit");
                    break;
                case 3:
                    Environment.Exit(-1);
                    break;

                default:
                    System.Console.WriteLine("Invalid option");
                    break;
            }
        }
        static double CtoF (int temp) {
            
            return  temp* 9 / 5f + 32;
        } 
        static double FtoC (int temp) {
           
            return (temp - 32) * 5 / 9f;
        }
    }
}
