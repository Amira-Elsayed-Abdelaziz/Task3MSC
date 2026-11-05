

namespace Task3MSC
{
    public class Book : LibraryItem
    {
        protected string Author { get; }
        public Book(string title, string author, int itemId)
        {
            Title = title;
            Author = author;
            ItemId = itemId;
        }
        public override void GetDetails()
        {
            Console.WriteLine($"Book: {Title}, Author: {Author}, ID: {ItemId}");
        }
    }
}
