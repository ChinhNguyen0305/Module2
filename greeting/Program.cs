using System;

namespace greeting
{
    class Program
    {
        static void Main(string[] args)
        {   System.Console.Write("Enter your name: ");
            String name =  Console.ReadLine();
            System.Console.WriteLine($"Hello {name}");
        }
    }
}
