using Solid_Principles.Models;

namespace Solid_Principles.Db
{
    public class BookDB
    {
        public void Save(Book book)
        {
            Console.WriteLine($"Guardamos {book.Name} y {book.Author}");
        }
    }
}
