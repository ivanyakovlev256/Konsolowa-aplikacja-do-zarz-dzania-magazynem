using ClassProduct;

namespace MennageProduct
{
    class Mennage
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(string name, int quantity, double price)
        {
            Product newProduct = new Product(name, quantity, price);
            products.Add(newProduct);
            Console.WriteLine("Produkt został dodany.");
        }

        public void RemoveProduct(string name)
        {
            Product productToRemove = null;

            foreach (var product in products)
            {
                if (product.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    productToRemove = product;
                    break;
                }
            }

            if (productToRemove != null)
            {
                products.Remove(productToRemove);
                Console.WriteLine("Produkt został usunięty.");
            }
            else
            {
                Console.WriteLine("Nie znaleziono produktu o podanej nazwie.");
            }
        }

        public void ShowProduct()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("Brak produktów do wyświetlenia.");
            }
            else
            {
                foreach (var product in products)
                {
                    Console.WriteLine($"Nazwa: {product.Name}, Ilość: {product.Quantity}, Cena: {product.Price} zł, Łączna cena: {product.GetTotalPrice()} zł");
                }
            }
        }
    }
}
