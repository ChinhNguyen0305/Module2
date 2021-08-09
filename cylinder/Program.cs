using System;

namespace cylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle FirstCircle = new Circle (30,"red");
            Cylinder firstCylin = new Cylinder(20,"darkcyan",50);
            System.Console.WriteLine(firstCylin.Area());
            firstCylin.Height = 40;
            System.Console.WriteLine(firstCylin.Volume());

        }
    }
}
