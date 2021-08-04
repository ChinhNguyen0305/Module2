// using System;

// namespace myupgradeMenu
// {
//     class Program
//     {
//         private const int Addition = 1;
//         private const int Substraction = 2;
//         private const int Multiply = 3;
//         private const int Divisor = 4;
//         private const int Exit = 5;

//         static void Main(string[] args)
//         {
//             Process();

//         }
//         public static void Process()
//         {
//             int selection = 0;
//             do
//             {
//                 BuildMenu(out selection);
//                 Console.Clear();
//                 switch (selection)
//                 {
//                     case Addition:
//                         {
//                             int number1 = EnterNumber("Enter number1:");
//                             int number2 = EnterNumber("Enter number2: ");
//                             System.Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
//                             break;
//                         }
//                     case Substraction:
//                         {
//                             int number1 = EnterNumber("Input subtrahend:");
//                             int number2 = EnterNumber("Input minus");
//                             System.Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
//                             break;
//                         }
//                     case Multiply:
//                         {
//                             int number1 = EnterNumber("Input number1: ");
//                             int number2 = EnterNumber("Input number2: ");
//                             System.Console.WriteLine($"{number1} x {number2} = {number1 * number2}");
//                             break;
//                         }
//                     case Divisor:
//                         {
//                             double number1 = (double)EnterNumber("Input number1: ");
//                             double number2 = (double)EnterNumber("Input number2: ");
//                             if (number2 == 0)
//                             {
//                                 System.Console.WriteLine("Invalid");
//                                 break;
//                             }
//                             else
//                             {
//                                 System.Console.WriteLine($"{number1} : {number2} = {number1 / number2}");
//                                 break;
//                             }

//                         }

//                     case Exit:
//                         {
//                             System.Console.WriteLine("Exit");
//                             Environment.Exit(0);
//                             break;
//                         }

//                 }
//             } while (selection != 5);


//         }

//         public static void BuildMenu(out int selection)
//         {

//             do
//             {
//                 System.Console.WriteLine("*********Calculator*********");
//                 System.Console.WriteLine("1.Adding");
//                 System.Console.WriteLine("2.Substract");
//                 System.Console.WriteLine("3.Multiply");
//                 System.Console.WriteLine("4.Division");
//                 System.Console.WriteLine("5.Exit");
//                 System.Console.WriteLine("******************************");
//                 System.Console.WriteLine("Choose function !");
//                 int.TryParse(Console.ReadLine(), out selection);

//             } while (selection < 1 || selection > 5);


//         }
//         public static int EnterNumber(string msg)
//         {
//             System.Console.WriteLine(msg);
//             int.TryParse(Console.ReadLine(), out int number);
//             return number;
//         }
//     }
// }

using System;

namespace Menu
{
    class Program
    {
        private const int addition = 1;
        private const int subtract = 2;
        private const int multiple = 3;
        private const int division = 4;
        private const int exitCode = 5;
        private const int min = 1;
        private const int max = 5;
        static void Main(string[] args)
        {
            Process();
        }

        private static void BuildMenu(out int selected)
        {
            do
            {
                Console.WriteLine("========== CALCULATOR ==========");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiple");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.WriteLine("================================");
                Console.Write("Choose a function: ");
                int.TryParse(Console.ReadLine(), out selected);
            }
            while (selected < min || selected > max);
        }

        public static void Process()
        {
            int selected = 0;
            do{
                BuildMenu(out selected);
                Console.Clear();
                switch (selected)
                {
                    case addition:{
                        int number1 = EnterNumber("Enter number 1: ");
                        int number2 = EnterNumber("Enter number 2: ");
                        Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
                        break;
                    }
                    case subtract:{
                        int number1 = EnterNumber("Enter subtrahend: ");
                        int number2 = EnterNumber("Enter minus: ");
                        Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
                        break;
                    }
                    case multiple:{
                        int number1 = EnterNumber("Enter number 1: ");
                        int number2 = EnterNumber("Enter number 2: ");
                        Console.WriteLine($"{number1} x {number2} = {number1 * number2}");
                        break;
                    }
                    case division:{
                        int number1 = EnterNumber("Enter devided: ");
                        int number2 = EnterNumber("Enter devisor: ");
                        if(number2 == 0){
                            Console.WriteLine("Divided by zero.");    
                        }
                        else{
                            Console.WriteLine($"{number1} : {number2} = {(double)number1 / (double)number2}");
                        }
                        break;
                    }
                    case exitCode:{
                        Environment.Exit(0);
                        break;
                    }
                }
            }
            while(selected != exitCode);
        }

        public static int EnterNumber(string msg){
            int number =0;
            bool isNumber = true;
            do{
                Console.Write(msg);
                isNumber = int.TryParse(Console.ReadLine(), out number);
            }
            while(!isNumber);
            return number;
        }
    }
}