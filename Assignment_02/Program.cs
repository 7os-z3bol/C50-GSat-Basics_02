class Program
{
    static void Main(string[] args)
    {
        /*
         // --> Question 1
         // Create an object of the Book class

         Book book1 = new Book();

         book1.Title = "The Great Gatsby";
         book1.Pages = 180;


         Console.WriteLine($"Book: {book1.Title}, Pages: {book1.Pages}");

         //--> Question 2


         Console.WriteLine(book1.ToString());
        Console.WriteLine(book1.GetHashCode());
        Console.WriteLine(book1.Equals(book1));
        Console.WriteLine(book1.GetType());
         */

        #region Q3


        // --> Question 3

        // int Pages = 464; // This is allowed because Pages is an integer and can be assigned an integer value. 

        #endregion

        #region Q 4
        /*
                int x = 10;
                int y = 0;
                try
                {
                    Console.WriteLine(x/y);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                finally
                        {
                    Console.WriteLine("Done");
                }
          */
        #endregion


        #region Q5

        int Pages = 300;

        double size = Pages;

        #endregion



    }
    #region Class Book
    /*

    class Book
    {
        public string Title;
        public int Pages;

        public override string ToString()
        {
            return $"Book: {Title}, Pages: {Pages}";
        }

    }
      */
    #endregion
}