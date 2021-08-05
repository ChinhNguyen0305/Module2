using System;

namespace MenuGeometry
{
    class Program
    {
        const int Square = 1;


        const int Rectangle = 2;


        const int Circle = 3;


        const int exitCode = 4;

        const int Area = 1;

        const int Perimeter = 2;
        const int exitSub = 3;
        static void Main(string[] args)
        {
            Process();
        }
        public static void BuildMenu(out int choice)
        {

            do
            {
                System.Console.WriteLine("======Geomatry Menu======");
                System.Console.WriteLine("1.Square");
                System.Console.WriteLine("2.Rectangle ");
                System.Console.WriteLine("3.Circle");
                System.Console.WriteLine("4.Exit");
                int.TryParse(Console.ReadLine(), out choice);
            } while (choice < 1 || choice > 4);
        }
        public static void BuildSubMenu(out int choice)
        {
            do
            {
                System.Console.WriteLine("1.Calulate Area:");
                System.Console.WriteLine("2.Calulate Perimeter:");
                System.Console.WriteLine("3.Back");
                int.TryParse(Console.ReadLine(), out choice);
            } while (choice < 1 || choice > 3);


        }
        public static void Process()
        {   back:
            int choice = 0;
            do
            {
                BuildMenu(out choice);
                Console.Clear();
                switch (choice)
                {
                    case Circle:
                        {
                            int calculate = 0;
                            do
                            {
                                BuildSubMenu(out calculate);
                                Console.Clear();
                                switch (calculate)
                                {
                                    case Area:
                                        {
                                            double value = EnterNumber("Input Radius:");
                                            System.Console.WriteLine($"Circle Area: {Math.Pow(value, 2) * Math.PI}");
                                            break;
                                        }
                                    case Perimeter:
                                        {
                                            double value = EnterNumber("Input Radius:");
                                            System.Console.WriteLine($"Circle Perimeter: {value * 2 * Math.PI}");
                                            break;

                                        }
                                    case exitSub:
                                        {
                                            goto back;
                                         
                                        }
                                }
                            } while (calculate != 3);
                            break;
                        }
                    case Rectangle:
                        {
                            int calculate = 0;
                            do
                            {
                                BuildSubMenu(out calculate);
                                switch (calculate)
                                {
                                    case Area:
                                        {
                                            double side1 = EnterNumber("Input Side 1:");
                                            double side2 = EnterNumber("Input Side 2:");
                                            System.Console.WriteLine($"Rectangle Area: {side1 * side2}");
                                            break;
                                        }
                                    case Perimeter:
                                        {
                                            double side1 = EnterNumber("Input Side 1:");
                                            double side2 = EnterNumber("Input Side 2:");
                                            System.Console.WriteLine($"Rectangle Area: {(side1 + side2) * 2}");
                                            break;
                                        }
                                    case exitSub:
                                        {
                                            goto back;
                                        }
                                }

                            } while (calculate != 3);

                            break;
                        }

                    case Square:
                        {
                            int calculate;
                            do
                            {   
                                BuildSubMenu(out calculate);
                                switch (calculate)
                                {
                                    case Area:
                                        {
                                            double side = EnterNumber("Enter square's side:");
                                            System.Console.WriteLine($"Square's are  {Math.Pow(side, 2)}");
                                            break;
                                        }
                                    case Perimeter:
                                        {
                                            double side = EnterNumber("Enter square's side:");
                                            System.Console.WriteLine($"Square's primeter: {side * 4}");
                                            break;
                                        }
                                    case exitSub:
                                        {
                                            goto back;
                                        }

                                }

                            } while (calculate != 3);


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

