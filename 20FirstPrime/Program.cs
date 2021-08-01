using System;

namespace _20FirstPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(checkPrime(13));
            int [] array = new int[20];
            
            }
        
        public static bool checkPrime(int number)
        {
            bool isPrime = true;
            if (number < 2)
            {
                return false;
            }
            if (number >= 2)
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            } return isPrime;
        }
    }
}

