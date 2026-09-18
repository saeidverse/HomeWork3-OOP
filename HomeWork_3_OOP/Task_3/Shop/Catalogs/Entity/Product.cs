

namespace Task_3.Shop.Catalogs.Entity
{
    class Product
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }


    
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }


        public virtual void GetProductDetails()
        {
            Console.Write($"Name:{Name} , Price:{Price} , ");
        }


    }
}
