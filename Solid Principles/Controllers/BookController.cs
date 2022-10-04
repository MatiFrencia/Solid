using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solid_Principles.Models;
using Solid_Principles.Service;

namespace Solid_Principles.Controllers
{
    public class BookController : Controller
    {

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }
            var bookService = new BookService();
            bookService.Create(book);

            return Ok();
        }
    }
}
