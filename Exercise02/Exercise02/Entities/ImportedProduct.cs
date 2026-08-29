using System.Globalization;

namespace Exercise02.Entities
{
    class ImportedProduct  : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) 
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return CustomsFee + base.Price;
        }

        public override string PriceTag()
        {
            return base.Name +
                " $ " +
                TotalPrice().ToString("F2", CultureInfo.InvariantCulture) +
                " (Customs fee: $ " +
                CustomsFee.ToString("F2", CultureInfo.InvariantCulture) +
                ")";
        }
    }
}