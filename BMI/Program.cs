using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Input weight: ");
            double  weight = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Input height in meter : ");
            double  height = Convert.ToDouble(Console.ReadLine());
            double BMI = Math.Round(weight/(Math.Pow(height,2)),2);

            if (BMI < 18)
            System.Console.WriteLine($"Your BMI is {BMI} Under Weight");
            else if (BMI < 25.0)
            System.Console.WriteLine($"Your BMI is {BMI} Normal");
            else if (BMI < 30) 
            System.Console.WriteLine($"Your BMI is {BMI} Over weight");
            else
            System.Console.WriteLine($"Your BMI is {BMI} Obese");
        }
    }
}
