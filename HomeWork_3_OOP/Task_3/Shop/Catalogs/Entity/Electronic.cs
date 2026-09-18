

using Task_3.Shop.Discounts.Interfaces;

namespace Task_3.Shop.Catalogs.Entity
{
    class Electronic : Product, IDiscountable
    {
        public int WarrantyPeriod { get; set; }
        public decimal DiscountPercent { get ; set; }

        public Electronic(string name, decimal price, int warrantyPeriod):base(name,price)
        {
            WarrantyPeriod = warrantyPeriod;
        }


       public decimal ApplyDiscount(decimal price, decimal discountPercent)
        {
            DiscountPercent = discountPercent;
            return price - (price * (discountPercent / 100));
        }

        public override void GetProductDetails()
        {
            base.GetProductDetails();
            Console.Write($"WarrantyPeriod:{WarrantyPeriod}");
        }

    }
}
