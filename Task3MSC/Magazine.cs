

namespace Task3MSC
{
    public class Magazine : LibraryItem
    {
        public DateTime IssueDate { get; set; }
        public Magazine(string title, DateTime issueDate, int itemId)
        {
            Title = title;
            IssueDate = issueDate;
            ItemId = itemId;
        }
        public override void GetDetails()
        {
            Console.WriteLine($"Magazine: {Title}, Issue Date: {IssueDate}, ID: {ItemId}");
        }
    }
}
