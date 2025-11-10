using System;
using System.Collections.Generic;
using System.Linq;
  
/*  
 Proyecto: Agenda Personal
 Estudiante: sebastian jimenez consoro
  Hice este proyecto desde cero porque quería aprender a hacerlo por mí mismo para entender mejor cómo funciona cada parte :v  
*/
  

Dictionary<int, Dictionary<string, string>> contacts = new();

bool close = false;

while (!close)
{
    Console.WriteLine("\n=== AGENDA PERSONAL ===");
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
            AddContact(contacts);
            break;
        case "2":
            Console.Clear();
            ViewContacts(contacts);
            break;
        case "3":
            Console.Clear();
            EditContacts(contacts);
            break;
        case "4":
            Console.Clear();
            DeleteContact(contacts);
            break;
        case "5":
            Console.Clear();
            SearchContact(contacts);
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

void AddContact(Dictionary<int, Dictionary<string, string>> contacts)
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
    contacts[id] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        { "Name", name },
        { "LastName", Lastname },
        { "Phone", phone },
        { "Email", email },
        { "Address", address },
        { "Favorite", isFavorite }
    };

    Console.Clear();
    Console.WriteLine("Contact added successfully.\n");
    Console.WriteLine("\nPress any key to return to menu...");
    Console.ReadKey();
    Console.Clear();
}

void ViewContacts(Dictionary<int, Dictionary<string, string>> contacts)
{
    Console.Clear();
    if (contacts.Count == 0)
    {
        Console.WriteLine("No contacts available.");
        return;
    }

    foreach (var contact in contacts)
    {
        Console.WriteLine($"ID: {contact.Key}");
        foreach (var detail in contact.Value)
        {
            Console.WriteLine($"{detail.Key}: {detail.Value}");
        }
        Console.WriteLine();
    }
    Console.WriteLine("\nPress any key to return to menu...");
    Console.ReadKey();
    Console.Clear();
}

void EditContacts(Dictionary<int, Dictionary<string, string>> contacts)
{
    ViewContacts(contacts);
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
        string field = option switch
        {
            "1" => "Name",
            "2" => "LastName",
            "3" => "Phone",
            "4" => "Email",
            "5" => "Address",
            "6" => "Favorite",
            _ => string.Empty
        };

        if (!string.IsNullOrEmpty(field))
        {
            Console.Write($"Enter new value for {field}: ");
            string newValue = Console.ReadLine() ?? string.Empty;
            contact[field] = newValue;
            Console.Clear();
            Console.WriteLine("Contact updated successfully.\n");
        }
        else
        {
            Console.WriteLine("Invalid option.");
        }
    }
    else
    {
        Console.WriteLine("Invalid contact ID.");
    }
    Console.WriteLine("\nPress any key to return to menu...");
    Console.ReadKey();
    Console.Clear();
}

void DeleteContact(Dictionary<int, Dictionary<string, string>> contacts)
{
    ViewContacts(contacts);

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

void SearchContact(Dictionary<int, Dictionary<string, string>> contacts)
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

    foreach (var contact in contacts)
    {
        int id = contact.Key;
        var data = contact.Value;

      
        if (data.Values.Any(v => v.ToLower().Contains(searchTerm)))
        {
            Console.WriteLine($"\nID: {id}");
            foreach (var field in data)
            {
                Console.WriteLine($"{field.Key}: {field.Value}");
            }
            found = true;
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
