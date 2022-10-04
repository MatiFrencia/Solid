namespace Solid_Principles;

public class Solid_L
{
    public void Main()
    {
        AbstractSale saleForeign = new SaleForeign(100, "Matias");
        saleForeign.Generate();

        SaleWithTaxes sale = new LocalSale(100, "Matias", 0.16m);
        sale.Generate();
        sale.CalculateTaxes();
    }

    public abstract class AbstractSale
    {
        protected decimal Amount;
        protected string Customer;
        public abstract void Generate();
    }
    public abstract class SaleWithTaxes : AbstractSale
    {
        protected decimal Taxes;
        public abstract void CalculateTaxes();
    }

    public class LocalSale : SaleWithTaxes
    {
        public LocalSale(decimal amount, string customer, decimal taxes)
        {
            this.Amount = amount;
            this.Customer = customer;
            this.Taxes = taxes;
        }
        public override void Generate()
        {
            Console.WriteLine("Se genera la venta");
        }
        public override void CalculateTaxes()
        {
            Console.WriteLine("Se Calculan impuestos");
        }
    }
    public class SaleForeign : AbstractSale
    {
        public SaleForeign(decimal amount, string customer)
        {
            this.Amount = amount;
            this.Customer = customer;
        }
        public override void Generate()
        {
            Console.WriteLine("Se genera la venta");
        }
    }

}
