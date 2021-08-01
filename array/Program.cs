using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = @"m \n osh";
            int[] array = new int[] { 1, 2, 3 };
            
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            
            Array.Resize(ref array, 10);
            
            
            Console.WriteLine(array);
            Console.WriteLine(a);
            
            
            string[] Fullname = new string[3] {"Hoa","phu","quy"};
            var fomartedString = String.Join(",",Fullname);
            System.Console.WriteLine(fomartedString);
        }
    }
}

