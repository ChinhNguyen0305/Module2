using System;

namespace divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            System.Console.Write("Enter first number: ");
            int b = int.Parse(Console.ReadLine());

            a = Math.Abs(a);
            b = Math.Abs(b);

            if (a == 0 && b == 0)
            {
                System.Console.WriteLine("There is no common divisor");
            }

            int maxDivisorAB = 1;
           
            for (int i = 1; i <= a / 2 || i <= b / 2; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    maxDivisorAB = i;
                }
            }
            // while (a != b)
            // {
            //     if (a > b)
            //         a = a - b;
            //     else
            //         b = b - a;
            // }
            // Console.WriteLine($"The greatest divisor : {a}");
            Console.WriteLine($"The greatest divisor : {maxDivisorAB}");


        }
    }
}
