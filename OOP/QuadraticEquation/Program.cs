using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadraticEquation FirstQuadratic = new QuadraticEquation(2, 4, 2);
            System.Console.WriteLine(FirstQuadratic.GetDiscriminant());
            // FirstQuadratic.GetResult(out double x2);
            // System.Console.WriteLine(FirstQuadratic.GetResult(out double x21));
            // System.Console.WriteLine(x2);
            FirstQuadratic.ShowResult();
            System.Console.WriteLine(FirstQuadratic.getB);

        }

        public class QuadraticEquation
        {
            private double a;
            private double b;
            private double c;
            public QuadraticEquation(double a, double b, double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public double GetA
            {
                get
                {
                    return a;
                }
            }
            public double getB
            {
                get
                {
                    return b;
                }
            }
            public double getC
            {
                get
                {
                    return c;
                }
            }
            public double GetDiscriminant()
            {
                double Delta = Math.Pow(b, 2) - 4 * a * c;
                return Delta;
            }
            public void ShowResult()
            {
                double x1;
                double x2;
                if (GetDiscriminant() > 0)
                {
                    x1 = (-b + Math.Sqrt(GetDiscriminant())) / (2 * a);
                    x2 = (-b - Math.Sqrt(GetDiscriminant())) / (2 * a);
                    System.Console.WriteLine($"{x1},{x2}");
                }
                else if (GetDiscriminant() == 0)
                {
                    System.Console.WriteLine($"x1 = x2 = {-b / (2 * a)}");

                }
                else if (GetDiscriminant() < 0)
                {
                    Console.WriteLine("No result");
                }
            }
            // public double GetResult (out double x2) {
            //     double x1;
            //     double v = (-b - Math.Sqrt(GetDiscriminant())) / (2 * a);
            //     double x2 = v;
            //     return x1 = (-b + Math.Sqrt(GetDiscriminant())) / (2 * a);
            // }
        }
    }
}

