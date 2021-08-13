namespace MyAnimal
{
    public class _cat : _Animal
    {
        private string Name { get; set; }
        // private int Weight {get;set;}
        // private int Height {get;set;}

        public _cat(double w, double h, string name) : base(w, h)
        {
            Name = name;
        }

        

        public override void Info()
        {
            System.Console.WriteLine($"Name : {Name} \nWeight: {Weight}  \nHeight: {Height}");
        }
    }
}