using Solid_Principles.Interfaces;

namespace Solid_Principles.Service
{
    public class InvoiceService
    {
        public decimal GetTotal(IEnumerable<IDrink> lstDrinks)
        {
            decimal total = 0;
            foreach(var drink in lstDrinks)
            {
                total += drink.GetPrice();
            }
            return total;
        }
    }
}
