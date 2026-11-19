namespace Session_2
{
    class Book
    {
        public string Title;
        public int Pages;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //object book = new Book { Title = ".NET", Pages = 444 };
            //Console.WriteLine($"Book Title:{((Book)book).Title}, Pages:{((Book)book).Pages}");
            #endregion

            #region Q02
            //Console.WriteLine(book.ToString());    //Session_2.Book
            //Console.WriteLine(book.Equals(book));  //True
            //Console.WriteLine(book.GetHashCode()); //37095509
            //Console.WriteLine(book.GetType());     //Session_2.Book
            #endregion

            #region Q03
            //int pages = "464";  // Compile-time error
            //int pages = int.Parse("464");
            ///OR
            //string pagesText = "464";
            //int pages = Convert.ToInt32(pagesText);
            #endregion

            #region Q04
            //int ten = 10, zero = 0;

            //try
            //{
            //    int result = ten / zero;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("Cannot divide by zero!");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}
            #endregion

            #region Q05
            //int pages = 300;
            //double pagesDouble = pages;  // int -> double happens implicitly

            //Console.WriteLine(pagesDouble);
            #endregion

            #region Q06     
            //double price = 49.99;
            //int priceInt = (int)price;

            //Console.WriteLine(priceInt);
            #endregion

            #region Q07
            //string pagesText = "464";
            //int pages = Convert.ToInt32(pagesText);
            //Console.WriteLine(pages);
            #endregion

            #region Q08
            //string yearText = "2023";
            //int year = int.Parse(yearText);

            //Console.WriteLine(year);

            //string badText = "abc";

            //if (int.TryParse(badText, out int newNumber))
            //{
            //    Console.WriteLine(newNumber);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number");
            //}
            #endregion

            #region Q09
            int pages = 464;
            string pagesText = pages.ToString();

            Console.WriteLine(pagesText);
            Console.WriteLine(pagesText.GetType());
            #endregion

        }
    }
}