

namespace Task3MSC
{
    public class Person
    {
        //Name and Age.
        public string Name { get; set; }
        private int Age;

        public Person()
        {
            Name = "Unknown";
            Age = 0;
        }
        public Person(string name, int age)
        {
            Name = name;
            SetAge(age);
        }
        public int GetAge()
        {
            return Age;
        }
        public void SetAge(int age)
        {
            if (age >= 10 && age <= 100)
            {
                Age = age;
            }
            else
            {
                Console.WriteLine("Age must be between 10 and 100.");
            }
        }
        public virtual void DisplayRole()
        {
            Console.WriteLine("This is a person.");
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
