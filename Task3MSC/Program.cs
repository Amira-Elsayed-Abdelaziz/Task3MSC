namespace Task3MSC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person student1 = new Student("Alice", 20, 3);
            Person librarian1 = new Librarian("Bob", 40, 50000m);

            student1.DisplayRole();
            student1.DisplayInfo();
            librarian1.DisplayRole();
            librarian1.DisplayInfo();

            LibraryItem book1 = new Book("C# Programming", "John Doe", 1);
            LibraryItem book2 = new Book("Java Programming", "Jane Smith", 2);
            LibraryItem magazine1 = new Magazine("Tech Monthly", DateTime.Now, 3);
            LibraryItem magazine2 = new Magazine("Science Weekly", DateTime.Now, 4);
            Library library = new Library();

            library.addLibraryItem(book1);
            library.addLibraryItem(book2);
            library.addLibraryItem(magazine1);
            library.addLibraryItem(magazine2);

            library.displayBooks();
        }
    }
}
