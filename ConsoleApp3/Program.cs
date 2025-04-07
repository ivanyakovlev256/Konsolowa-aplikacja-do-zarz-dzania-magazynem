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

    switch (choice)
    {
        case "1":
            Console.Write("Podaj nazwę produktu: ");
            string name = Console.ReadLine();

            Console.Write("Podaj ilość produktu: ");
            int quantity = int.Parse(Console.ReadLine());

            Console.Write("Podaj cenę produktu: ");
            double price = double.Parse(Console.ReadLine());

            manager.AddProduct(name, quantity, price);
            break;

        case "2":
            Console.Write("Podaj nazwę produktu, który chcesz usunąć: ");
            string nameToDelete = Console.ReadLine();

            manager.RemoveProduct(nameToDelete);
            break;

        case "3":
            manager.ShowProduct();
            break;

        case "4":
            Console.Write("Podaj nazwę produktu, który chcesz edytować: ");
            string nameToEdit = Console.ReadLine();

            Console.WriteLine("Co chcesz edytować?");
            Console.WriteLine("1. Zmień nazwę");
            Console.WriteLine("2. Zmień ilość");
            Console.WriteLine("3. Zmień cenę");
            string editChoice = Console.ReadLine();

            switch (editChoice)
            {
                case "1":
                    Console.Write("Podaj nową nazwę: ");
                    string newName = Console.ReadLine();
                    manager.EditProduct(nameToEdit, newName: newName);
                    break;

                case "2":
                    Console.Write("Podaj nową ilość: ");
                    int newQuantity = int.Parse(Console.ReadLine());
                    manager.EditProduct(nameToEdit, newQuantity: newQuantity);
                    break;

                case "3":
                    Console.Write("Podaj nową cenę: ");
                    double newPrice = double.Parse(Console.ReadLine());
                    manager.EditProduct(nameToEdit, newPrice: newPrice);
                    break;

                default:
                    Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie.");
                    break;
            }
            break;

        case "5":
            Console.WriteLine("Zakończono program.");
            return; // Zamiast `break`, użycie `return` kończy aplikację

        default:
            Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie.");
            break;
    }

    Console.WriteLine("\nNaciśnij dowolny klawisz, aby kontynuować...");
    Console.ReadKey();
}
