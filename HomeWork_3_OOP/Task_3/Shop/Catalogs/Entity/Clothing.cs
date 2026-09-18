

namespace Task_3.Shop.Catalogs.Entity
{
    class Clothing:Product
    {
        public int Size { get; set; }
        public string? Material { get; set; }

        public Clothing(string name, decimal price,int size,string material):base(name,price)
        {
            Size = size;
            Material = material;
        }


        public override void GetProductDetails()
        {
            base.GetProductDetails();
            Console.Write($"Size:{Size} ,Material:{Material}");
        }


    }
}
