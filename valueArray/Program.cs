using System;

namespace valueArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = {
                "Christian", "Michael", "Camila", "Sienna", "Tanya",
                "Connor", "Zachariah", "Mallory", "Zoe", "Emily"};

            Console.Write("Enter student's name:");
            string inputName = Console.ReadLine();

            bool isExist = false;
            int index = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Equals(inputName))
                {
                    isExist = true;
                    index = i;
                    break;
                }
            }
            System.Console.WriteLine(isExist? $"{inputName} is in the array at {index}" : $"{inputName} is not in array");
            
        }   

    }
}
