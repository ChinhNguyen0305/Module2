namespace inherit
{
    class Animal
    {
        protected string Name { get; set; }
        public double Weight;
        protected double Height;

        protected int Legs;

       
        public Animal(string name, double weight, int legs) 
        {
            Name = name;
            Weight = weight;
            Legs = legs;
        }
         public virtual void info()
        {
            System.Console.WriteLine($"Weight = {this.Weight} Height = {Height} legs: {Legs}");
        }

  

    }
}