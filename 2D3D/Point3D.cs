namespace _2D3D
{
    public class Point3D : Point2D
    {
        public float Z {get;set;}
        public Point3D(float x, float y,float z):base (x,y)
        {   
            Z = z;
        }
        public Point3D()
        {
            
        }
        public void SetXYZ (float x, float y, float z) {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return $"{base.ToString()} Z = {Z}" ;
        }
        public float[] getXYZ {
            get {
                float [] XYZ = new float[3] {X,Y,Z};
                return XYZ;
            }
        }
        
        
       
}
}