using clases;

ContactManager manager = new ContactManager();

bool close = false;

while (!close)
{
    Console.WriteLine("\n===MENU===");
    Console.WriteLine("1. Add contact");
    Console.WriteLine("2. View contacts");
    Console.WriteLine("3. Edit contact");
    Console.WriteLine("4. Delete contact");
    Console.WriteLine("5. Search contact");
    Console.WriteLine("6. Exit");

    string option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.Clear();
            manager.AddContact();
            break;

        case "2":
            Console.Clear();
            manager.ViewContacts();
            break;

        case "3":
            Console.Clear();
            manager.EditContacts();
            break;

        case "4":
            Console.Clear();
            manager.DeleteContact();
            break;

        case "5":
            Console.Clear();
            manager.SearchContact();
            break;

        case "6":
            close = true;
            break;

        default:
            Console.Clear();
            Console.WriteLine("Invalid option. Try again.");
            break;
    }
}

namespace clases
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Email { get; set; } = "";
        public string Address { get; set; } = "";
        public string Favorite { get; set; } = "No";
    }

    public class ContactManager
    {
        private Dictionary<int, Contact> contacts = new();

        public void AddContact()
        {
            Console.Write("Enter contact name: ");
            string name = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter contact Lastname: ");
            string Lastname = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter contact phone number: ");
            string phone = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter contact email: ");
            string email = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter contact Address: ");
            string address = Console.ReadLine() ?? string.Empty;

            Console.Write("Do you want to add this contact to favorites? (y/n): ");
            string FavoriteContact = Console.ReadLine() ?? string.Empty;

            string isFavorite = (FavoriteContact.ToLower() == "y") ? "Yes" : "No";

            int id = contacts.Count + 1;

            contacts[id] = new Contact
            {
                Id = id,
                Name = name,
                LastName = Lastname,
                Phone = phone,
                Email = email,
                Address = address,
                Favorite = isFavorite
            };

            Console.Clear();
            Console.WriteLine("Contact added successfully.\n");
            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
            Console.Clear();
        }

        public void ViewContacts()
        {
            Console.Clear();
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts available.");
                return;
            }

            foreach (var contact in contacts.Values)
            {
                Console.WriteLine($"ID: {contact.Id}");
                Console.WriteLine($"Name: {contact.Name}");
                Console.WriteLine($"LastName: {contact.LastName}");
                Console.WriteLine($"Phone: {contact.Phone}");
                Console.WriteLine($"Email: {contact.Email}");
                Console.WriteLine($"Address: {contact.Address}");
                Console.WriteLine($"Favorite: {contact.Favorite}");
                Console.WriteLine();
            }

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
            Console.Clear();
        }

        public void EditContacts()
        {
            ViewContacts();
            Console.Write("Enter the ID of the contact you want to edit: ");

            if (int.TryParse(Console.ReadLine(), out int id) && contacts.ContainsKey(id))
            {
                var contact = contacts[id];

                Console.WriteLine("Select the field to edit:");
                Console.WriteLine("1. Name");
                Console.WriteLine("2. LastName");
                Console.WriteLine("3. Phone");
                Console.WriteLine("4. Email");
                Console.WriteLine("5. Address");
                Console.WriteLine("6. Favorite");

                string option = Console.ReadLine() ?? string.Empty;

                Console.Write("Enter new value: ");
                string newValue = Console.ReadLine() ?? string.Empty;

                switch (option)
                {
                    case "1": contact.Name = newValue; break;
                    case "2": contact.LastName = newValue; break;
                    case "3": contact.Phone = newValue; break;
                    case "4": contact.Email = newValue; break;
                    case "5": contact.Address = newValue; break;
                    case "6": contact.Favorite = newValue; break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                Console.Clear();
                Console.WriteLine("Contact updated successfully.\n");
            }
            else
            {
                Console.WriteLine("Invalid contact ID.");
            }

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
            Console.Clear();
        }

        public void DeleteContact()
        {
            ViewContacts();

            Console.Write("\nEnter the ID of the contact you want to delete: ");

            if (int.TryParse(Console.ReadLine(), out int id))
            {
                if (contacts.ContainsKey(id))
                {
                    Console.Write($"Are you sure you want to delete contact #{id}? (y/n): ");
                    string confirm = Console.ReadLine()?.Trim().ToLower() ?? "";

                    if (confirm == "y")
                    {
                        contacts.Remove(id);
                        Console.WriteLine("Contact deleted successfully!\n");
                    }
                    else
                    {
                        Console.WriteLine("Deletion canceled.\n");
                    }
                }
                else
                {
                    Console.WriteLine("No contact found with that ID.\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID.\n");
            }

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
            Console.Clear();
        }

        public void SearchContact()
        {
            Console.WriteLine("\n=== SEARCH CONTACT ===");

            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts registered.");
                return;
            }

            Console.Write("Enter the name, last name, or any data to search: ");
            string searchTerm = Console.ReadLine()?.ToLower() ?? "";

            bool found = false;

            foreach (var c in contacts.Values)
            {
                if (c.Name.ToLower().Contains(searchTerm) ||
                    c.LastName.ToLower().Contains(searchTerm) ||
                    c.Phone.ToLower().Contains(searchTerm) ||
                    c.Email.ToLower().Contains(searchTerm) ||
                    c.Address.ToLower().Contains(searchTerm) ||
                    c.Favorite.ToLower().Contains(searchTerm))
                {
                    Console.WriteLine($"\nID: {c.Id}");
                    Console.WriteLine($"Name: {c.Name}");
                    Console.WriteLine($"LastName: {c.LastName}");
                    Console.WriteLine($"Phone: {c.Phone}");
                    Console.WriteLine($"Email: {c.Email}");
                    Console.WriteLine($"Address: {c.Address}");
                    Console.WriteLine($"Favorite: {c.Favorite}");
                    found = true;
                    Console.WriteLine();
                }
            }

            if (!found)
            {
                Console.WriteLine("No contacts found with that term.");
            }

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
