using System;

namespace linearEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear Equation Resolver: ");
            Console.WriteLine("Given an equation as 'ax + b = 0'");
            Console.WriteLine("Enter a:");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            double b = Double.Parse(Console.ReadLine());


            if (a != 0 && b != 0)
            {
                double solution = -b / a;
                System.Console.WriteLine($"The solution is {solution}");
            }
            else if (a == 0)
            {
                if (b == 0)
                {
                    System.Console.WriteLine("The solution is all x!");
                }
                else
                {
                    System.Console.WriteLine("No Slution");
                }
            }



        }
    }
}
