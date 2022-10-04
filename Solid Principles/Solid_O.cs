
namespace Solid_Principles
{
    
    public class Solid_O
    {

        public decimal GetTotal(IEnumerable<IDrink> lstDrinks)
        {
            decimal total = 0;
            foreach (var drink in lstDrinks)
            {
                total += drink.GetPrice();
            }
            return total;
        }
        public interface IDrink
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public decimal Invoice { get; set; }
            public decimal GetPrice()
            {
                return Price * Invoice;
            }
        }
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
}
