
class Book
{
    public string Title { get; set; }
    public string AuthorFullName { get; set; }
    public bool IsBorrowed { get; set; }

    public Book(string title, string authorFullName, bool isBorrowed)
    {
        this.Title = title;
        this.AuthorFullName = AuthorFullName;
        this.IsBorrowed = isBorrowed;
    }

    public void BorrowBook()
    {
        if (!IsBorrowed)
        {
            IsBorrowed = true;
            Console.WriteLine($"You have borrowed this Book: {Title} .");
        }
        else
        {
            Console.WriteLine($"This book: {Title} is already borrowed.");
        }
    }

    public void ReturnBook()
    {
        if (IsBorrowed)
        {
            IsBorrowed = false;
            Console.WriteLine($"The book: {Title} has been return.");
        }
        else 
        {
            Console.WriteLine($"The book: {Title} wasn't borrowed.");
        }
    }

}