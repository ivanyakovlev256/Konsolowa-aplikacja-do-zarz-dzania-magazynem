using MennageProduct;

Mennage manager = new Mennage();

while (true)
{
    Console.Clear(); 
    Console.WriteLine("\nWybierz opcję:");
    Console.WriteLine("1. Dodaj produkt");
    Console.WriteLine("2. Usuń produkt");
    Console.WriteLine("3. Wyświetl produkty");
    Console.WriteLine("4. Edytuj produkt");
    Console.WriteLine("5. Zakończ");
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
        Console.Write("Podaj nazwę produktu, który chcesz edytować: ");
        string nameToEdit = Console.ReadLine();

        Console.WriteLine("Co chcesz edytować?");
        Console.WriteLine("1. Zmień nazwę");
        Console.WriteLine("2. Zmień ilość");
        Console.WriteLine("3. Zmień cenę");
        string editChoice = Console.ReadLine();

        if (editChoice == "1")
        {
            Console.Write("Podaj nową nazwę: ");
            string newName = Console.ReadLine();
            manager.EditProduct(nameToEdit, newName: newName);
        }
        else if (editChoice == "2")
        {
            Console.Write("Podaj nową ilość: ");
            int newQuantity = int.Parse(Console.ReadLine());
            manager.EditProduct(nameToEdit, newQuantity: newQuantity);
        }
        else if (editChoice == "3")
        {
            Console.Write("Podaj nową cenę: ");
            double newPrice = double.Parse(Console.ReadLine());
            manager.EditProduct(nameToEdit, newPrice: newPrice);
        }
        else
        {
            Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie.");
        }
    }
    else if (choice == "5")
    {
        Console.WriteLine("Zakończono program.");
        break;
    }
    else
    {
        Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie.");
    }

    Console.WriteLine("\nNaciśnij dowolny klawisz, aby kontynuować...");
    Console.ReadKey(); 
}
