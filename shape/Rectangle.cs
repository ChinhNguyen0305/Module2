namespace shape
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }

        public double Length { get; set; }

        public Rectangle()
        {
            Width = 1;
            Length = 1;
        }

        public Rectangle (double w, double l) 
        {
            Width = w;
            Length = l;
        }
        public Rectangle (double width, double length, string color, bool filled) : base (color,filled) 
        {
            Width = width;
            Length = length;
        }

        public double GetArea()
        {
            return Width * Length;
        }
        public double GetPerimeter()
        {
            return (Width + Length) * 2;
        }

        public override string ToString()
        {
            return $"A rectangle with Width = {Width} Height = {Length} is a subclass of {base.ToString()}";
        }
    }
}