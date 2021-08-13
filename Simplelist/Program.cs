using System;
using System.Collections;
using System.Collections.Generic;

namespace Simplelist
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> il = new MyList<int>();
            il.Add(4);
            il.Add(5);
            il.Add(6);
            il.Add(7);
            il.Add(8);
            il.Add(9);
            il.Add(10);

            for (int i = 0; i< il.Capacity;i++){
                System.Console.WriteLine($"{i+1} = {il.GetData(i)}");
            }
            il.GetData(-1);
        }
    }
}
