namespace shape
{
    public class Shape
    {   private string Color {get;set;}
        private  bool Filled {get;set;}
        public Shape()
        {
            Color = "green";
            Filled = true;
        }
        public Shape(string color, bool filled)
        {
            Color = color;
            Filled = filled;
        }
        public override string ToString()
        {   string isFilled = Filled?"filled":"not filled";
            return $"A shape with color of {Color} and is {isFilled}";
        }
    }
}