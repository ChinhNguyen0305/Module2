using System;

namespace learning
{
    class Program
    {
        public class Person
        {
            public int Age;
        }
        public enum ShippingMethod
        {
            Yahh,
            Sun,
            Haki

        }
        static void Main(string[] args)
        {

            var numb = 10;
            Increment(numb);
            System.Console.WriteLine(numb);
            //imidiately destroyed
            var person1 = new Person() { Age = 20 };
            makeOlder(person1);
            System.Console.WriteLine(person1.Age);

        }
        public static void Increment(int number)
        {
            number += 10;
        }
        public static void makeOlder(Person person)
        {
            person.Age += 10;
        }

    }
}

