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
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Addresses { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string ZipCode { get; set; }
            public string PhoneNumber { get; set; }
            public string EmailId { get; set; }
        }
        public static void Contact()
        {
            char choice;
            Console.Write("\nDo you wish to add new Contact (Y/N) : ");
            choice = Convert.ToChar(Console.ReadLine());
            while (choice == 'y' || choice == 'Y')
            {
                Person person = new Person();

                Console.Write("\nEnter First Name : ");
                person.FirstName = Console.ReadLine();

                Console.Write("Enter Last Name : ");
                person.LastName = Console.ReadLine();

                Console.Write("Enter Address : ");
                person.Addresses = Console.ReadLine();

                Console.Write("Enter City : ");
                person.City = Console.ReadLine();

                Console.Write("Enter State : ");
                person.State = Console.ReadLine();

                Console.Write("Enter ZipCode : ");
                person.ZipCode = Console.ReadLine();

                Console.Write("Enter Phone Number : ");
                person.PhoneNumber = Console.ReadLine();

                Console.Write("Enter EmailId : ");
                person.EmailId = Console.ReadLine();

                People.Add(person);
                Console.Write("\nDo you wish to add new Contact (Y/N) : ");
                choice = Convert.ToChar(Console.ReadLine());
            }
        }
        public static void PrintContact(Person person)
        {
            Console.WriteLine("First Name : " + person.FirstName);
            Console.WriteLine("Last Name : " + person.LastName);
            Console.WriteLine("Address : " + person.Addresses);
            Console.WriteLine("City : " + person.City);
            Console.WriteLine("State : " + person.State);
            Console.WriteLine("ZipCode : " + person.ZipCode);
            Console.WriteLine("Phone Number : " + person.PhoneNumber);
            Console.WriteLine("EmailId : " + person.EmailId);
            Console.WriteLine("\n-------------------------------------------");
        }
        public static void ListOfPeoples()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("\nYour Address book is Empty");
                Console.WriteLine("\n\tPress Any key To Exit");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("\nContacts In The Address Book:\n");
            foreach (var person in People)
            {
                PrintContact(person);
            }
            Console.WriteLine("\n\tPress Any key To Exit");
            Console.ReadKey();
        }
    }
}
