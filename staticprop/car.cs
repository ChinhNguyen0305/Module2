namespace staticprop
{
    public class car
    {
        internal string name { get; set; }
        internal string enginne { get; set; }

        public static int numberOfCars { get; set; }

        public car(string name, string enginne)
        {
            this.name = name;
            this.enginne = enginne;
            numberOfCars++;

        }

    }
}