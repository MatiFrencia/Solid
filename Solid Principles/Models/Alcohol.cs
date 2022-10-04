using Solid_Principles.Interfaces;

namespace Solid_Principles.Models
{
    public class Alcohol : IDrink
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Invoice { get; set; }
        public decimal Promo { get; set; }
        public decimal GetPrice()
        {
            return (Price * Invoice) - Promo;
        }
        public Alcohol(string name, decimal price, decimal invoice, decimal promo)
        {
            this.Name = name;
            this.Price = price;
            this.Invoice = invoice;
            this.Promo = promo;
        }
    }
}

