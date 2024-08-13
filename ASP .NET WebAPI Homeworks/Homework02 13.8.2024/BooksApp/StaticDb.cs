using BooksApp.Model;

namespace BooksApp
{
    public static class StaticDb
    {
        //Add static list of book objects

        public static List<Book> Books = new List<Book>()
        {
            new Book(){Title="A Time to Kill", Author="John Grisham"},
            new Book(){Title="The House of Mirth", Author="Edith Wharton"},
            new Book(){Title="East of Eden", Author="Ernest Hemingway"},
            new Book(){Title="Number of Stars ", Author="Lois Lowry"},

        };
    }
}
