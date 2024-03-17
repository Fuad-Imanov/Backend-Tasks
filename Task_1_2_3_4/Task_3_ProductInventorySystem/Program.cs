using CustomExceptionLibrary;
using Task_3_ProductInventorySystem;
try
{
    Book book = new Book("Book Title", 10.99m, 100, "Author Name", 200);
    book.Sell(10);
    book.ShowInfo();

    book.Sell(5);
    book.ShowInfo();

    book.Sell(115);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

catch (ProductCountIsZeroException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

catch (InvalidOperationException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}