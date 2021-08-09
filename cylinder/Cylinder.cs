namespace cylinder
{
    public class Cylinder:Circle
    {
        public double Height {get;set;}
        public Cylinder()
        {
            
        }
        public Cylinder(double r, string color, double h):base(r,color)
        {
            Height = h;
        }
        public double Volume () {
            return Area()*Height;
        }
    }
}