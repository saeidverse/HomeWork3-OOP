
using Task_3.Shop.Catalogs.Entity;
using Task_3.Shop.Discounts.Interfaces;

List<Product> products = new List<Product>();

products.Add(new Electronic("laptop", 120000, 24));
products.Add(new Clothing("T-shirt", 1000, 42, "parche"));

foreach (var product in products)
{
 
    if (product is IDiscountable discountable)
    {

       
        decimal applyDiscount = discountable.ApplyDiscount(product.Price, 15);
        decimal discountPercent = discountable.DiscountPercent;
        Console.Write($" ,  Discount Percent:{discountPercent}% , Apply Discount:{applyDiscount}"); 
    }
    else
    {
        Console.Write($" , Discount:None");
    }

    Console.WriteLine();
    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");

}
