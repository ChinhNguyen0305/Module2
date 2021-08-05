using System;


namespace Quadratic
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadraticEquation firstEquation = new QuadraticEquation(4,-2,-6);           
            System.Console.WriteLine(firstEquation.GetDiscriminant());
            firstEquation.ShowResult();


        }

    }
}
