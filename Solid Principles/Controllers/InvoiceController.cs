using Microsoft.AspNetCore.Mvc;
using Solid_Principles.Db;
using Solid_Principles.Service;

namespace Solid_Principles.Controllers
{
    public class InvoiceController : Controller
    {
        [HttpGet]
        [ValidateAntiForgeryToken]
        public decimal GetTotal()
        {
            var invoiceService= new InvoiceService();
            var drinks = new DrinkDB().All();
            var total = invoiceService.GetTotal(drinks);

            return total;
        }
    }
}
