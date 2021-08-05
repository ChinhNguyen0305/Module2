namespace MyAnimal
{
    public abstract class _Animal
    {
        protected double Weight {get;set;}
        protected double Height {get;set;}

        public _Animal(double w,double h) 
        {
            Weight = w;
            Height = h;
        }
        public abstract void Info();
    }
}