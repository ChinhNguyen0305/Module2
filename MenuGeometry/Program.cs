using System;

namespace MenuGeometry
{
    class Program
    {
        const int TriangleArea = 1;
        const int TrianglePerimeter = 2;

        const int RectangleArea = 3;
        const int RectanglePerimeter = 4;

        const int CircleArea = 5;
        const int CirclePerimeter = 6;

        const int exitCode = 7;

        static void Main(string[] args)
        {
            Process();
        }
        public static void BuildMenu(out int choice)
        {

            do
            {
                System.Console.WriteLine("======Geomatry Menu======");
                System.Console.WriteLine("1.Triangle square");
                System.Console.WriteLine("2.Triangle perimeter");
                System.Console.WriteLine("3.Rectangle square");
                System.Console.WriteLine("4.Rectangle perimeter");
                System.Console.WriteLine("5.Circle square");
                System.Console.WriteLine("6.Circle perimeter");
                System.Console.WriteLine("7.Exit");
                int.TryParse(Console.ReadLine(), out choice);
            } while (choice < 1 || choice > 7);
        }
        public static void BuildSubMenu () {
                System.Console.WriteLine("1.Calulate Area:");
                System.Console.WriteLine("2.Calulate Perimeter:");
                System.Console.WriteLine("3.Back");
        }
        public static void Process()
        {
            int choice = 0;
            do
            {
                BuildMenu(out choice);
                Console.Clear();


                switch (choice)
                {
                    case TriangleArea:
                        {
                            System.Console.WriteLine("input radius: ");
                            double.TryParse(Console.ReadLine(), out double radius);
                            System.Console.WriteLine($"Triangle's Area {radius * radius * 3.14}");
                            break;
                        }
                    

                    case exitCode:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            } while (choice != exitCode);




        }
        public static double EnterNumber(string msg)
        {
            System.Console.WriteLine(msg);
            double.TryParse(Console.ReadLine(), out double value);
            return value;
        }
        
    }

}

