using System;

namespace shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle round = new Circle (20,"DarkCyan",true);
            System.Console.WriteLine(round.ToString());
            Square cube2 = new Square (20,"red",false);
            System.Console.WriteLine(cube2.ToString());
            Rectangle reckt = new Rectangle(20,30,"FireBrick",false);
            System.Console.WriteLine(reckt.ToString());

        }
    }
}
