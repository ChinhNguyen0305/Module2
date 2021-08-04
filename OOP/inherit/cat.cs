namespace inherit
{
     class Cat : Animal
    {   public bool HasClaw { get; set; }
        public Cat(string name, double weight, int legs,bool HC):base (name,weight,legs)
        {
            HasClaw = HC;

        }
        public override string info() {
            return $"{base.info()}, does it have claw? {HasClaw}";
        } 
        
    }
}