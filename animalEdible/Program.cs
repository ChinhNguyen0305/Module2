using System;

namespace animalEdible
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[2];
            animals[0] = new Tiger();
            animals[1] = new Chicken();
            foreach (Animal animal in animals)
            {
                System.Console.WriteLine(animal.MakeSound());

                if (animal is Chicken)
                {
                    Edible edibler = (Chicken)animal;
                    System.Console.WriteLine(edibler.HowToEat());
                }
            }

            Fruit[] Fruits = new Fruit[2];
            Fruits[0] = new Orange();
            Fruits[1] = new Apple();
            foreach (Fruit fruit in Fruits) 
            {
                System.Console.WriteLine(fruit.HowToEat());
            }
        }
    }
}
