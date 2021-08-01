using System;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Boolean check = true;
            if (number < 2)
                System.Console.WriteLine($"{number} is no prime");

            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        check = false;
                        break;
                    }
                }
                System.Console.WriteLine(check? $"{number} is prime" : $"{number} is not prime");
                }
            }
        }


    }



