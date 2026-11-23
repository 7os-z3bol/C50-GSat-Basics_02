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

        //int Pages = 300;

        //double size = Pages;

        #endregion

        #region Q6

        //double Price = 49.99;
        //int cost = Convert.ToInt32(Price);
        #endregion

        #region Q7
        //string PagesText = "464";
        //int Pages = Convert.ToInt32(PagesText); // Convert string to int using Convert Class
        #endregion

        #region Q8

        //string yearText = "2023";
        //int year = int.Parse(yearText); // Convert string to int using Parse method

        //string badText = "abc";
        //try
        //{
        //    int badNumber = int.Parse(badText); // This will throw an exception
        //}
        //catch (FormatException)
        //{
        //    Console.WriteLine($"Error: '{badText}' is not a valid number.");
        //}

        #endregion

        #region Q9

        //int Pages = 464;
        //string PagesText = Pages.ToString(); // Convert int to string using ToString method
        //Console.WriteLine(PagesText.GetType());
        #endregion

        #region Q10
        //int Copies = 100;
        //object CopiesObject = Copies; // Boxing: int to object
        //Console.WriteLine(CopiesObject);

        //int CopiesUnboxed = (int)CopiesObject; // Unboxing: object to int
        //Console.WriteLine(CopiesUnboxed);
        #endregion

        #region Q11
        //int? year = null;
        //Console.WriteLine(year.HasValue);
        //year = 2023;
        //Console.WriteLine(year.HasValue);
        //Console.WriteLine(year);

        #endregion


        #region Q12
        string? Book = null;
        Console.WriteLine(Book);
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