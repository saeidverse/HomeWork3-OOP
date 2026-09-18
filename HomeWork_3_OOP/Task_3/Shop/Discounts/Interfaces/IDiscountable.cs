

namespace Task_3.Shop.Discounts.Interfaces
{
    interface IDiscountable
    {
        decimal DiscountPercent { get; set; }
        decimal ApplyDiscount(decimal price, decimal discountPercent);

    }
}
