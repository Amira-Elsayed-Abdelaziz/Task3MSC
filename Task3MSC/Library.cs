

namespace Task3MSC
{
    public class Library
    {
        public List<LibraryItem> Items = new List<LibraryItem>() { };
        public void displayBooks()
        {
            foreach (var Item in Items)
            {
                Item.GetDetails();
            }
        }
        public void addLibraryItem(LibraryItem newItem)
        {
            Items.Add(newItem);
        }
    }
}
