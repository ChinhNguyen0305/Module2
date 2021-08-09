namespace shape
{
    public class Square : Rectangle
    {
        private double Side { get; set; }
        public Square()
        {
            Side = 1;
        }

        public Square(double side) : base(side, side)
        {
        }

        public Square(double side, string color, bool filled) : base(side, side, color, filled)
        {
        }
        public double Getside
        {
            get
            {
                return Width;
            }
        }
       
        public override string ToString()
        {
            return $@"A square with side = {base.Width}
            Square's perimeter {GetPerimeter()}
            Square's Area {GetArea()}
            is a subclass of
            {base.ToString()}";
        }

    }
}