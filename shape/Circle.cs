using System;
namespace shape
{
    public class Circle : Shape
    {
        double Radius { get; set; }
        double Diameter { get; set; }
        public Circle()
        {
            Radius = 1;
        }
        public Circle(double r)
        {
            Radius = r;
        }
        public Circle(double r, string color,bool filled):base (color,filled)
        {
            Radius = r;
            
        }
        public override string ToString()
        {
            return $@"A circle with radius {Radius},
            which is a subclass of {base.ToString()}";
        }

        public double GetPerimeter () 
        {
            return Radius*2*3.14;
        }
        public double GetArea () {
            return Math.Pow(Radius,2)*Math.PI;
        }     

    }
}