using System;

namespace buildstudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Sun = new Student(2345,"Sun","Nirvana",24);
            Student Zed = new Student();
            Zed._Id = 1918198096;
            Zed._Name = "Zed";
            Zed._Adress = "Hue";
            Zed._Age = 300;
        
            System.Console.WriteLine(Sun.info());
            System.Console.WriteLine(Zed.info());
            

        }
    }
}
