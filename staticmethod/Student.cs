namespace staticmethod
{
    public class Student
    {
        private int Rollno;
        private string Name;
        private static string college = "BBDIT";

        public Student (int r, string n, string cl) {
            Rollno = r;
            Name = n;
            college = cl;
        }
        public static void change () {
            college = "CODEGYM";
        }
        public void Display () {
            System.Console.WriteLine($"roll no {Rollno} name {Name} {college}");
        }
    }   
}