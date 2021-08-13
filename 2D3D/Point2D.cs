namespace _2D3D
{
    public class Point2D
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Point2D(float x, float y)
        {
            X = x;
            Y = y;
        }
        public Point2D()
        {

        }

        public void SetXY(float x, float y)
        {
            X = x;
            Y = y;
        }
        // public float[] getXY()
        // {
        //     float[] XY = new float[2] { X, Y };
        //     return XY;
        // }
        public float[] getXY
        {
            get
            {   float[] XY = new float[2] { X, Y };
                return XY;
            }
        }
        public  override string ToString()
        {
            return $"2D point's X = {X}, Y = {Y}";
        }
    }
}