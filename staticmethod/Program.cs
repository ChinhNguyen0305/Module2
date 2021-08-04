using System;

namespace staticmethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Sun = new Student (20,"Sun","Red");
            Student Zed = new Student (24,"Zed","Silver");
           
            Student.change();
            Sun.Display();
            Zed.Display();


        }
    }
}
