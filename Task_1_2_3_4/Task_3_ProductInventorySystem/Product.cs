namespace Task_3_ProductInventorySystem
{
    public abstract class Product
    {

        private static int _idCounter = 0;
        public Product(string name,decimal price,int count)
        {
            
            Id = ++_idCounter;
            Name = name;
            Price = price;
            Count = count;
        }
        public int Id { get; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public decimal TotalInCome { get; protected set; }
        public abstract void Sell(int quantity = 1);
        public abstract void ShowInfo();
    }
}
