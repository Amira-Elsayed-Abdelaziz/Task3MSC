

namespace Task3MSC
{
    public class Student : Person
    {
        public int Level { get; set; }

        public Student(string name, int age, int level) : base(name, age)
        {
            Level = level;
        }

        public override void DisplayRole()
        {
            Console.WriteLine("This is a student.");
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Level: {Level}");
        }
    }
}
