using MennageProduct;

Mennage manager = new Mennage();

while (true)
{
    Console.WriteLine("\nWybierz opcję:");
    Console.WriteLine("1. Dodaj produkt");
    Console.WriteLine("2. Usuń produkt");
    Console.WriteLine("3. Wyświetl produkty");
    Console.WriteLine("4. Zakończ");
    string choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.Write("Podaj nazwę produktu: ");
        string name = Console.ReadLine();

        Console.Write("Podaj ilość produktu: ");
        int quantity = int.Parse(Console.ReadLine());

        Console.Write("Podaj cenę produktu: ");
        double price = double.Parse(Console.ReadLine());

        manager.AddProduct(name, quantity, price);
    }
    else if (choice == "2")
    {
        Console.Write("Podaj nazwę produktu, który chcesz usunąć: ");
        string nameToDelete = Console.ReadLine();

        manager.RemoveProduct(nameToDelete);
    }
    else if (choice == "3")
    {
        manager.ShowProduct();
    }
    else if (choice == "4")
    {
        Console.WriteLine("Zakończono program.");
        break;
    }
    else
    {
        Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie.");
    }
}