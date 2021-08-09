namespace learning
{
    public class Animal
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public Animal()
        {           
        }
        public void info() {
            System.Console.WriteLine($"name = {Name}, h ={Height} w {Weight}");
        }

    }
}