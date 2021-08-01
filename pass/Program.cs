using System;

namespace pass
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int counter = 0;
            System.Console.Write("input number of students:");
            int NumberOfStudents = Int32.Parse(Console.ReadLine());
            while (i < NumberOfStudents)
            {
                System.Console.WriteLine($"Nhap diem sinh vien thu {i + 1}: ");
                int score = Convert.ToInt32(Console.ReadLine());
                if (score > 10 || score < 0)
                {
                    System.Console.WriteLine("invalid score");
                    Environment.Exit(1);
                }
                else if (score > 5)
                {
                    counter++;
                }
                i++;
            }
            System.Console.WriteLine($"Number of passed students: {counter}");
        }
    }
}
