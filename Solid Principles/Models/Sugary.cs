using Solid_Principles.Interfaces;

namespace Solid_Principles.Models
{
    public class Sugary : IDrink
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Invoice { get; set; }
        public decimal Expiration { get; set; }
        public decimal GetPrice()
        {
            return (Price * Invoice) - Expiration;
        }
        public Sugary(string name, decimal price, decimal invoice, decimal expiration)
        {
            this.Name = name;
            this.Price = price;
            this.Invoice = invoice;
            this.Expiration = expiration;
        }
    }
}
