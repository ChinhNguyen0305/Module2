using System;
namespace Quadratic
{
    public class QuadraticEquation
    {
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }
        public QuadraticEquation(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;

        }

        public double GetDiscriminant()
        {
            double delta = Math.Pow(B, 2) - (4 * A * C);
            return delta;
        }

        public void GetRoot1()
        {

            System.Console.WriteLine($"Equation has two results :\nx1={(-B + Math.Sqrt(GetDiscriminant())) / (2 * A)} \nx2={(-B - Math.Sqrt(GetDiscriminant())) / (2 * A)}");

        }

        public void GetRoot2()
        {

            System.Console.WriteLine($"Equation has 1 result: {-B / (2 * A)}");

        }
        public void GetRoot3()
        {

            System.Console.WriteLine($"Equation has no result");

        }
        public void ShowResult()
        {
            if (GetDiscriminant() > 0)
            {
                GetRoot1();
            }
            else if (GetDiscriminant() == 0)
            {
                GetRoot2();
            }
            else
                GetRoot3();
        }

    }
}