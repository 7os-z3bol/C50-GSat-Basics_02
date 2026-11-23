class Program
{
    static void Main(string[] args)
    {
        // --> Question 1
        // Create an object of the Book class

        Book book1 = new Book();

        book1.Title = "The Great Gatsby";
        book1.Pages = 180;


        Console.WriteLine($"Book: {book1.Title}, Pages: {book1.Pages}");
    }
    #region Class Book

    
    class Book
    {
        public string Title;
        public int Pages;

        public override string ToString()
        {
            return $"Book: {Title}, Pages: {Pages}";
        }

    }
        
        #endregion
}