using System;

namespace MobilePhone
{
    class Mobiphone
    {
        static void Main(string[] args)
        {
        Automobile ipx = new Automobile("","Jetpack",2000);
        System.Console.WriteLine(ipx);
        System.Console.WriteLine(ipx.Make);
        

        }
        public class Automobile
        {
            public Automobile(string make, string model, int year)
            {
                if (make == null)
                    throw new ArgumentNullException ("This can not be a null, please enter maker");
                else if (String.IsNullOrWhiteSpace(make))
                    throw new ArgumentException("make cannot be an empty string or have space characters only.");
                Make = make;

                if (model == null)
                    throw new ArgumentNullException("The model cannot be null.");
                else if (String.IsNullOrWhiteSpace(model))
                    throw new ArgumentException("model cannot be an empty string or have space characters only.");
                Model = model;

                if (year < 1857 || year > DateTime.Now.Year + 2)
                    throw new ArgumentException("The year is out of range.");
                Year = year;
            }

            public string Make { get; set;}

            public string Model { get; set;}

            public int Year { get; set;}

            public override string ToString() => $"{Year} {Make} {Model}";
        }
    }
}