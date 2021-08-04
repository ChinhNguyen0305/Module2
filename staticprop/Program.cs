using System;

namespace staticprop
{
    class Program
    {
        static void Main(string[] args)
        {
            car car1 = new car("Mazada3", "Skyacitive 3");
            System.Console.WriteLine(car.numberOfCars);
            car car2 = new car ("Jet","Hellish Enginne");
            System.Console.WriteLine(car.numberOfCars);
            
        }
    }
}
