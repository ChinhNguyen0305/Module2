using System;

namespace cylinder
{
    public class Circle
    {
        protected double Radius {get;set;}
        protected string Color {get;set;}
        public Circle()
        {            
        }
        public Circle(double r, string color)
        {
            Radius = r;
            Color = color;
        }
        public double Area () {
            return Math.Pow(Radius,2)*Math.PI;
        }

    }
}