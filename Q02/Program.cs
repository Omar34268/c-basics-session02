Book myBook = new Book();
myBook.Title = "Clean Code";
myBook.Pages = 464;

object book = myBook;

Console.WriteLine(book.ToString());
Console.WriteLine(book.Equals(book));
Console.WriteLine(book.GetHashCode());
Console.WriteLine(book.GetType());

class Book
{
    public string Title = "";
    public int Pages;
}
