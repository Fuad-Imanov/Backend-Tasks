using CustomExceptionLibrary;

namespace Task_3_ProductInventorySystem
{
    public class Book : Product
    {
        public string AuthorName { get; }
        public int PageCount { get; }

        public Book(string name, decimal price, int count, string authorName, int pageCount)
            : base(name, price, count)
        {
            AuthorName = authorName;
            PageCount = pageCount;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Count: {Count}");
            Console.WriteLine($"Total Income: {TotalInCome:C}");
            Console.WriteLine($"Author: {AuthorName}");
            Console.WriteLine($"Page Count: {PageCount}");
            Console.WriteLine("------------------------");
        }

        public override void Sell(int quantity = 1)
        {
            if (quantity <= 0) throw new ArgumentException("Quantity must be greater than zero.");

            if (Count == 0) throw new ProductCountIsZeroException("Count can not be 0");

            if (Count < quantity) throw new InvalidOperationException("Not enough stock available.");

            Count -= quantity;
            TotalInCome += Price * quantity;
        }

       
    }
}
