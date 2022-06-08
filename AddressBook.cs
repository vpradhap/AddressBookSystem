using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {
        public static List<Person> People = new List<Person>();
        public class Person
        {
            public string Addressbookname { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Addresses { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string ZipCode { get; set; }
            public string PhoneNumber { get; set; }
            public string EmailId { get; set; }
        }
        public static void Contact(string addressbookname)
        {
            string choice;
            Console.Write("\nDo you wish to add new Contact ? (Y/N) : ");
            choice = Console.ReadLine();
            while (choice == "y" || choice == "Y")
            {
                //bool exist = false;
                Person person = new Person();

                Console.Write("\nEnter First Name   : ");
                person.FirstName = Console.ReadLine();

                Console.Write("Enter Last Name    : ");
                person.LastName = Console.ReadLine();

                Console.Write("Enter Address      : ");
                person.Addresses = Console.ReadLine();

                Console.Write("Enter City         : ");
                person.City = Console.ReadLine();

                Console.Write("Enter State        : ");
                person.State = Console.ReadLine();

                Console.Write("Enter ZipCode      : ");
                person.ZipCode = Console.ReadLine();

                Console.Write("Enter Phone Number : ");
                person.PhoneNumber = Console.ReadLine();

                Console.Write("Enter EmailId      : ");
                person.EmailId = Console.ReadLine();

                person.Addressbookname = addressbookname;

                //foreach (var per in People.ToList())
                //{
                //    if (per.FirstName == person.FirstName && per.LastName == person.LastName && per.Addresses == person.Addresses && per.City == person.City && per.State == person.State && per.ZipCode == person.ZipCode && per.PhoneNumber == person.PhoneNumber && per.EmailId == person.EmailId && per.Addressbookname == person.Addressbookname) 
                //    {
                //exist = true;
                //Console.WriteLine("\nContact already present");
                //    }
                //}
                var matchingPerson = People.Where(x => x.FirstName == person.FirstName && x.LastName == person.LastName && x.Addressbookname == person.Addressbookname).ToList();
                if (matchingPerson.Any())
                {
                    Console.WriteLine("\nContact already present");
                }
                else
                {
                    People.Add(person);
                }
                Console.Write("\nDo you wish to add new Contact ? (Y/N) : ");
                choice = Console.ReadLine();
            }
        }
        public static void PrintContact(Person person)
        {
            Console.WriteLine("\nFirst Name   : " + person.FirstName);
            Console.WriteLine("Last Name    : " + person.LastName);
            Console.WriteLine("Address      : " + person.Addresses);
            Console.WriteLine("City         : " + person.City);
            Console.WriteLine("State        : " + person.State);
            Console.WriteLine("ZipCode      : " + person.ZipCode);
            Console.WriteLine("Phone Number : " + person.PhoneNumber);
            Console.WriteLine("EmailId      : " + person.EmailId);
            Console.WriteLine("\n-------------------------------------------");
        }
        public static void Modify()
        {   
            if (People.Count != 0)
            {
                string choice;
                Console.Write("\nDo you wish to Modify Contact ? (Y/N) : ");
                choice = Console.ReadLine();
                while (choice == "y" || choice == "Y")
                {
                    Console.Write("\nEnter the first name of a contact to modify : ");
                    string Modified = Console.ReadLine();
                    bool exist = false;
                    foreach (var person in People)
                    {
                        if (person.FirstName.ToUpper() == Modified.ToUpper())
                        {
                            exist = true;
                            Console.WriteLine("\nChoose the field to modify ");
                            Console.WriteLine("\nEnter 1 to Change First name ");
                            Console.WriteLine("Enter 2 to Change Last name ");
                            Console.WriteLine("Enter 3 to Change Address ");
                            Console.WriteLine("Enter 4 to Change City ");
                            Console.WriteLine("Enter 5 to Change State ");
                            Console.WriteLine("Enter 6 to Change Zipcode ");
                            Console.WriteLine("Enter 7 to Change Phone Number ");
                            Console.WriteLine("Enter 8 to Change EmailId ");
                            Console.Write("\nYour Choice : ");
                            string Check = Console.ReadLine();
                            switch (Check)
                            {
                                case "1":
                                    Console.Write("\nEnter the New First Name: ");
                                    person.FirstName = Console.ReadLine();
                                    break;
                                case "2":
                                    Console.Write("\nEnter the New Last Name: ");
                                    person.LastName = Console.ReadLine();
                                    break;
                                case "3":
                                    Console.Write("\nEnter the New Address: ");
                                    person.Addresses = Console.ReadLine();
                                    break;
                                case "4":
                                    Console.Write("\nEnter the New City: ");
                                    person.City = Console.ReadLine();
                                    break;
                                case "5":
                                    Console.Write("\nEnter the New State: ");
                                    person.State = Console.ReadLine();
                                    break;
                                case "6":
                                    Console.Write("\nEnter the New Pin Code : ");
                                    person.ZipCode = Console.ReadLine();
                                    break;
                                case "7":
                                    Console.Write("\nEnter the New Phone Number : ");
                                    person.PhoneNumber = Console.ReadLine();
                                    break;
                                case "8":
                                    Console.Write("\nEnter the New EmailId : ");
                                    person.EmailId = Console.ReadLine();
                                    break;
                                default:
                                    Console.WriteLine("\n\tEnter a valid choice");
                                    break;
                            }
                        }
                    }
                    if(exist == false)
                    {
                        Console.WriteLine("\nEnter the valid name");
                    }
                    Console.Write("\nDo you wish to Modify Contact ? (Y/N) : ");
                    choice = Console.ReadLine();
                }
            }
        }
        public static void Delete()
        {
            if (People.Count != 0)
            {
                string choice;
                Console.Write("\nDo you wish to delete Contact ? (Y/N) : ");
                choice = Console.ReadLine();
                while (choice == "y" || choice == "Y")
                {
                    Console.Write("\nEnter the first name of a contact to delete : ");
                    string remove = Console.ReadLine();
                    bool exist = false;
                    foreach (var person in People.ToList())
                    {
                        if (person.FirstName.ToUpper() == remove.ToUpper())
                        {
                            exist = true;
                            People.Remove(person);
                            Console.WriteLine("Contact is deleted");
                        }
                    }
                    if (exist == false)
                    {
                        Console.WriteLine("Contact is not present");
                    }
                    Console.Write("\nDo you wish to delete Contact ? (Y/N) : ");
                    choice = Console.ReadLine();
                }
            }
        }
        public static void ListOfPeoples(string name)
        {
            bool exist = false;
            foreach (var person in People)
            {
                if (exist == false && person.Addressbookname == name)
                {
                    exist = true;
                }
            }
            if (exist == true)
            {
                Console.WriteLine("\nAvailable contacts are : ");
                foreach (var person in People)
                {
                    if (person.Addressbookname == name)
                    {
                        PrintContact(person);
                    }   
                }
            }
            else
            {
                Console.WriteLine("\nContacts list is empty ");
                Console.WriteLine("\n-------------------------------------------");
            }
            
        }
        public static void SearchPerson()
        {
            if (People.Count != 0)
            {
                string choice;
                Console.Write("\nDo you wish to search person in the Address Book ? (Y/N) : ");
                choice = Console.ReadLine();
                while (choice == "y" || choice == "Y")
                {
                    string input;
                    Console.Write("\nEnter first name to search : ");
                    string firstname = Console.ReadLine();
                    Console.Write("Enter last name to search : ");
                    string lastname = Console.ReadLine();
                    Console.WriteLine("\nBy which medium do you wish to search ");
                    Console.WriteLine("1 - City");
                    Console.WriteLine("2 - State");
                    Console.Write("Enter your choice : ");
                    string option = Console.ReadLine();
                    Person person = new Person();

                    switch (option)
                    {
                        case "1":
                            Console.Write("\nEnter the city name to search : ");
                            input = Console.ReadLine();
                            var matchingPerson = People.Where(x => x.FirstName == firstname && x.LastName == lastname && x.City == input).ToList();
                            foreach (var match in matchingPerson)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Addressbook name : " + match.Addressbookname + "\n" + "First name : " + match.FirstName + "\n" + "Last name : " + match.LastName);
                            }
                            break;
                        case "2":
                            Console.Write("\nEnter the state name to search : ");
                            input = Console.ReadLine();
                            matchingPerson = People.Where(x => x.FirstName == firstname && x.LastName == lastname && x.State == input).ToList();
                            foreach (var match in matchingPerson)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Addressbook name : " + match.Addressbookname + "\n" + "First name : " + match.FirstName + "\n" + "Last name : " + match.LastName);
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                    Console.Write("\nDo you wish to search person in the Address Book ? (Y/N) : ");
                    choice = Console.ReadLine();
                }
            }  
        }
        public static void ViewPerson()
        {
            if (People.Count != 0)
            {
                string choice;
                Console.Write("\nDo you wish to view persons in the Address Book ? (Y/N) : ");
                choice = Console.ReadLine();
                while (choice == "y" || choice == "Y")
                {
                    string input; 
                    Console.WriteLine("\nBy which medium do you wish to view ");
                    Console.WriteLine("1 - City");
                    Console.WriteLine("2 - State");
                    Console.Write("Enter your choice : ");
                    string option = Console.ReadLine();
                    Person person = new Person();

                    switch (option)
                    {
                        case "1":
                            Console.Write("\nEnter the city name to search : ");
                            input = Console.ReadLine();
                            var matchingPerson = People.Where(x => x.City == input).ToList();
                            foreach (var match in matchingPerson)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Addressbook name : " + match.Addressbookname + "\n" + "First name : " + match.FirstName + "\n" + "Last name : " + match.LastName);
                            }
                            break;
                        case "2":
                            Console.Write("\nEnter the state name to search : ");
                            input = Console.ReadLine();
                            matchingPerson = People.Where(x => x.State == input).ToList();
                            foreach (var match in matchingPerson)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Addressbook name : " + match.Addressbookname + "\n" + "First name : " + match.FirstName + "\n" + "Last name : " + match.LastName);
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                    Console.Write("\nDo you wish to view persons in the Address Book ? (Y/N) : ");
                    choice = Console.ReadLine();
                }
            }
        }
    }
}
