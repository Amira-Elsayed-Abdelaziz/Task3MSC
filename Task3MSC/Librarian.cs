
namespace Task3MSC
{
    public class Librarian : Person
    {

        public decimal Salary { get; set; }
        public Librarian(string name, int age, decimal salary) : base(name, age)
        {
            Salary = salary;
        }
        public override void DisplayRole()
        {
            Console.WriteLine("This is a librarian.");
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Salary: {Salary:C}");
        }
    }
}
