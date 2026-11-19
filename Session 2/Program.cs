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
            #region Question01
            object book = new Book { Title = ".NET", Pages = 444 };
            Console.WriteLine($"Book Title:{((Book)book).Title}, Pages:{((Book)book).Pages}");
            #endregion

        }
    }
}