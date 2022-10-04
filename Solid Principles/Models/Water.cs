using Solid_Principles.Interfaces;

namespace Solid_Principles.Models
{
    public class Water : IDrink
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Invoice { get; set; }

        public Water(string name, decimal price, decimal invoice)
        {
            this.Name = name;
            this.Price = price;
            this.Invoice = invoice;
        }
    }
}
