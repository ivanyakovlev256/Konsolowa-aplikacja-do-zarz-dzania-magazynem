namespace ClassProduct
{
    class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product(string name, int quantity, double price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public double GetTotalPrice()
        {
            return Quantity * Price;
        }
    }
}
