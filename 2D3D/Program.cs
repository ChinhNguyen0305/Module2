using System;

namespace _2D3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D _2d = new Point2D(10,15);
            _2d.SetXY(20,30);
            System.Console.WriteLine(_2d.ToString());
            Point3D _3d = new Point3D(20,30,40);
            System.Console.WriteLine(_3d.ToString());
            foreach(float value in _3d.getXYZ) {
                System.Console.WriteLine(value);
            }

        }
    }
}
