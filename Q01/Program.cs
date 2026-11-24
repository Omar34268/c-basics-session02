Book myBook = new Book();
myBook.Title = "Clean Code";
myBook.Pages = 464;

object book = myBook;
Console.WriteLine(book);

class Book
{
    public string Title = "";
    public int Pages;
}
