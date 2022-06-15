using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBookSelection
    {
        public static Dictionary<string, AddressBook> addressBookMapper = new Dictionary<string, AddressBook>();
        public static void AddressBookAdding()
        {
            string choice;
            Console.Write("\nDo you wish to Add New Address Book ? (Y/N) : ");
            choice = Console.ReadLine();
            while (choice == "y" || choice == "Y")
            {
                Console.Write("\nEnter a name for New Address Book : ");
                string name = Console.ReadLine();
                if (addressBookMapper.ContainsKey(name))
                {
                    int i=1;
                    Console.WriteLine("\nName already exist");
                    Console.Write("\nAvailable names are : ");
                    foreach (KeyValuePair<string, AddressBook> check in addressBookMapper)
                    {
                        Console.Write(i + "." + check.Key + "  ");
                        i++;
                    }
                    Console.WriteLine("");
                }
                else
                {
                    AddressBook addressBook = new AddressBook();
                    addressBookMapper.Add(name, addressBook);
                }
                Console.Write("\nDo you wish to Add New Address Book ? (Y/N) : ");
                choice = Console.ReadLine();
            }
        }
        public static void AddressBookSelect()
        {
            if (addressBookMapper.Count != 0)
            {
                string choice;
                Console.Write("\nDo you wish to choose Address Book ? (Y/N) : ");
                choice = Console.ReadLine();
                while (choice == "y" || choice == "Y")
                {
                    int i = 1;
                    Console.Write("\nEnter Name of the address book you want to use : ");
                    string name = Console.ReadLine();
                    if (!addressBookMapper.ContainsKey(name))
                    {
                        Console.Write("\nAddress book "+ name+" not found \n\nAvailable names are : ");
                        foreach (KeyValuePair<string, AddressBook> check in addressBookMapper)
                        {
                            Console.Write(i+"."+check.Key+"  ");
                            i++;
                        }
                        Console.WriteLine("");
                    }
                    else
                    {
                        AddressBook address = addressBookMapper[name];
                        AddressBook.Contact(name);
                        AddressBook.Modify();
                        AddressBook.Delete();
                    }
                    Console.Write("\nDo you wish to choose Address Book ? (Y/N) : ");
                    choice = Console.ReadLine();
                }
            }
        }
        public static void DeletingAddressBook()
        {
            if (addressBookMapper.Count != 0)
            {
                string choice;
                Console.Write("\nDo you wish to delete Address Book ? (Y/N) : ");
                choice = Console.ReadLine();
                while (choice == "y" || choice == "Y")
                {
                    int i = 1;
                    Console.Write("\nEnter Name of address book to delete : ");
                    string name = Console.ReadLine();
                    if (!addressBookMapper.ContainsKey(name))
                    {
                        Console.Write("\nAddress book " + name + " not found \n\nAvailable names are : ");
                        foreach (KeyValuePair<string, AddressBook> check in addressBookMapper)
                        {
                            Console.Write(i+"."+check.Key +"  ");
                            i++;
                        }
                        Console.WriteLine("");
                    }
                    else
                    {
                        addressBookMapper.Remove(name);
                    }
                    Console.Write("\nDo you wish to delete Address Book ? (Y/N) : ");
                    choice = Console.ReadLine();
                }
            }
        }
        public static void DisplayingAddressBooks()
        {
            if (addressBookMapper.Count == 0)
            {
                Console.WriteLine("\nAddress book list is empty");
                Console.WriteLine("\n\tPress Any key To Exit");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine("\n----------------------------------------------------------------");
                foreach (KeyValuePair<string, AddressBook> dictionaryPair in addressBookMapper)
                {
                    Console.WriteLine("\nAddress book : " + dictionaryPair.Key);
                    AddressBook address = dictionaryPair.Value;
                    AddressBook.ListOfPeoples(dictionaryPair.Key);
                }
                Console.WriteLine("\n\tPress Any key To Exit");
                Console.ReadKey();
            }
        }
       
        public static void ReadFromTextFile()
        {
            string path = @"D:\BridgeLabz\Regular Fellowship Program -146\Visual Studio 2022\Assignments\AddressBookSystem\AddressBookSystem\ReadFile.txt";
            Console.WriteLine("\nReading data from a text file\n");
            if (File.Exists(path))
            {
                using (StreamReader reader = File.OpenText(path))
                {
                    string line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }

        public static void WriteToTextFile()
        {
            foreach (KeyValuePair<string, AddressBook> dictionaryPair in addressBookMapper)
            {
                AddressBook address = dictionaryPair.Value;
                address.AddContactsToTextFile(dictionaryPair.Key);
            }
            Console.WriteLine("\nContact details added to the file");
        }
    }
}
/*public static void EditDetailsOfAddressBook()
       {
           if(addressBookMapper.Count != 0)
           {
               Console.Write("\nEnter Name of address book to modify contact details : ");
               string name = Console.ReadLine();
               if (!addressBookMapper.ContainsKey(name))
               {
                   Console.WriteLine("No address book found with this name");
                   Console.WriteLine("Please Enter Valid Name from following names : ");
                   foreach (KeyValuePair<string, AddressBook> check in addressBookMapper)
                   {
                       Console.WriteLine(check.Key);
                   }
               }
               else
               {
                   AddressBook address = addressBookMapper[name];
                   AddressBook.Modify();
               }
           }  
       }
       public static void DeleteContactsOfAddressBook()
       {
           if (addressBookMapper.Count != 0)
           {
               Console.Write("\nEnter Name of address book to delete contact details : ");
               string name = Console.ReadLine();
               if (!addressBookMapper.ContainsKey(name))
               {
                   Console.WriteLine("No address book found with this name");
                   Console.WriteLine("Please Enter Valid Name from following names:");
                   foreach (KeyValuePair<string, AddressBook> check in addressBookMapper)
                   {
                       Console.WriteLine(check.Key);
                   }
               }
               else
               {
                   AddressBook address = addressBookMapper[name];
                   AddressBook.Delete();
               }
           }
       }*/