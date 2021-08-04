using System;

namespace inherit
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat heo = new Cat("heo",20,4,true);
            heo.info();
            string b = heo.HasClaw? "Yes" : "No";
            System.Console.WriteLine(b);

        }

    }



}
