using System;

namespace OOPbegin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width: ");
            float.TryParse(Console.ReadLine(), out float width);
            Console.WriteLine("Enter the height: ");
            float.TryParse(Console.ReadLine(), out float height);

            Rectangle FirstRect = new Rectangle(width, height);
            System.Console.WriteLine(FirstRect.Display());
        }
    
        class Rectangle
        {
            double width, height;
            public Rectangle(float height, float width)
            {
                this.height = height;
                this.width = width;
            }
            public double GetArea()
            {
                return this.width * this.height;
            }
            public double GetPerimeter()
            {
                return (this.width + this.height) * 2;
            }
            public string Display()
            {
                return $"The Rectangle's Area: {GetArea()}, perimeter: {GetPerimeter()}";
            }

        }
    }
}
