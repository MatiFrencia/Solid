namespace Solid_Principles;

public class Solid_S
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public Book(string name, string author)
        {
            this.Name = name;
            this.Author = author;
        }
    }

    public class BookDB
    {
        private Book _book;
        public BookDB(Book book)
        {
            _book = book;
        }

        public void Save()
        {
            Console.WriteLine($"Guardamos {_book.Name} y {_book.Author}");
        }
    }
    public class BookRequest
    {
        private Book _book;
        public BookRequest(Book book)
        {
            _book = book;
        }

        public void Send()
        {
            Console.WriteLine($"Enviamos {_book.Name} y {_book.Author}");
        }
    }
}
