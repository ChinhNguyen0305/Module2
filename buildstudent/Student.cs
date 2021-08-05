namespace buildstudent
{
    public class Student
    {
        private int Id;
        private string Name;
        private string Adress;
        private int Age;
        public Student()
        {
        }

        public Student(int _id, string _name, string _address, int _age)
        {
            Id = _id;
            Name = _name;
            Adress = _address;
            Age = _age;
        }
        public int _Id { get => Id; set => Id = value; }
        public string _Name { get => Name; set => Name = value; }
        public string _Adress { get => Adress; set => Adress = value; }
        public int _Age { get => Age; set => Age = value; }

        public string info  () {
            return $"Id: {Id} Name {Name} Address {Adress} Age {Age}";
        }
    }
}