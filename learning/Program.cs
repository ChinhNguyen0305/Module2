using System;

namespace learning
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };

            Animal Cat = new Animal () {
                Name = "Cat",
                Weight = 20
            };
            Animal[] animals = new Animal[2] {
               new Animal() {
                "Cat",
                 30,
                 20
               },
               new Animal () {
                   Name ="dog",
                   Weight = 40,
                   Height = 20
               }
           };
           foreach(Animal a in animals) {
               a.info();
           }
           Cat.info();
        }

    }
}

