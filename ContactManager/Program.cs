ContactManager manager = new ContactManager();

while (true)
{
    Console.WriteLine("\n--- Contact Manager ---");
    Console.WriteLine("1. Add contact");
    Console.WriteLine("2. Search");
    Console.WriteLine("3. Delete");
    Console.WriteLine("4. Show all");
    Console.WriteLine("5. Exit");
    Console.Write("Choose: ");

    string choice = Console.ReadLine() ?? "";

    switch (choice)
    {
        case "1": AddContact(manager); break;
        case "2": SearchContacts(manager); break;
        case "3": DeleteContact(manager); break;
        case "4": ShowAll(manager); break;
        case "5":
            Console.WriteLine("Goodbye!");
            return;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }
}

static void AddContact(ContactManager manager)
{
    Console.Write("Name: ");
    string name = (Console.ReadLine() ?? "").Trim();
    Console.Write("Phone: ");
    string phone = (Console.ReadLine() ?? "").Trim();
    Console.Write("Email: ");
    string email = (Console.ReadLine() ?? "").Trim();

    if (name == "" || phone == "")
    {
        Console.WriteLine("Name and phone are required.");
        return;
    }

    if (manager.Add(new Contact(name, phone, email)))
        Console.WriteLine("Contact added.");
    else
        Console.WriteLine("A contact with this phone already exists.");
}

static void SearchContacts(ContactManager manager)
{
    Console.Write("Search (name or phone): ");
    string keyword = (Console.ReadLine() ?? "").Trim();

    List<Contact> results = manager.Search(keyword);

    if (results.Count == 0)
    {
        Console.WriteLine("No contacts found.");
        return;
    }
    foreach (Contact c in results)
        Console.WriteLine(c);
}

static void DeleteContact(ContactManager manager)
{
    Console.Write("Phone of the contact to delete: ");
    string phone = (Console.ReadLine() ?? "").Trim();

    if (manager.Delete(phone))
        Console.WriteLine("Contact deleted.");
    else
        Console.WriteLine("Contact not found.");
}

static void ShowAll(ContactManager manager)
{
    List<Contact> all = manager.GetAll();

    if (all.Count == 0)
    {
        Console.WriteLine("No contacts yet.");
        return;
    }
    for (int i = 0; i < all.Count; i++)
        Console.WriteLine($"{i + 1}. {all[i]}");
}