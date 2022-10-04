namespace Solid_Principles.Interfaces
{
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
}
