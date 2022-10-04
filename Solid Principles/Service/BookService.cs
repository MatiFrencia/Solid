using Solid_Principles.Db;
using Solid_Principles.Models;
using Solid_Principles.Utils;

namespace Solid_Principles.Service
{
    public class BookService
    {
        public void Create(Book book)
        {
            var bookDB = new BookDB();
            var log = new Log();

            bookDB.Save(book);
            log.Save("Se guarda un libro " + book.GetInfo());
        }
    }
}
