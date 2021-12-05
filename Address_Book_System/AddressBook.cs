using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Address_Book_System
{
    class AddressBook
    {
        private static List<PersonsDetails> contacts = new List<PersonsDetails>();

        private static Dictionary<string, List<PersonsDetails>> addressBook = new Dictionary<string, List<PersonsDetails>>();

        public static Dictionary<string, List<PersonsDetails>> cityBook = new Dictionary<string, List<PersonsDetails>>();
        public static Dictionary<string, List<PersonsDetails>> stateBook = new Dictionary<string, List<PersonsDetails>>();

        public static void AddTo(string name)
        {
            addressBook.Add(name, contacts);
        }
        public static void AddContact()
        {
           PersonsDetails person = new PersonsDetails();
            
            Console.Write(" Enter your First name : ");
            person.FirstName = Console.ReadLine();
            Console.Write(" Enter your Last name : ");
            person.LastName = Console.ReadLine();
            Console.Write(" Enter your Address : ");
            person.Address = Console.ReadLine();
            Console.Write(" Enter your City : ");
            person.City = Console.ReadLine();
            Console.Write(" Enter your State : ");
            person.State = Console.ReadLine();
            Console.Write(" Enter your Zip Code : ");
            person.ZipCode = Console.ReadLine();
            Console.Write(" Enter your Phone Number : ");
            person.PhoneNumber = Console.ReadLine();
            Console.Write(" Enter your Email-ID : ");
            person.Email = Console.ReadLine();

            contacts.Add(person);
            Console.WriteLine("\n {0}'s contact succesfully added", person.FirstName);
        }
 
        public static void Details()
        {
            if(contacts.Count == 0)
            {
                Console.WriteLine("Currently there are no people added in your address book.");
            }
            else
            {
                Console.WriteLine("Here is the list and details of all the contacts in your addressbook.");

                foreach (var Detailing in contacts)
                {
                    Console.WriteLine("First name : " + Detailing.FirstName);
                    Console.WriteLine("Last name : " + Detailing.LastName);
                    Console.WriteLine("Address : " + Detailing.Address);
                    Console.WriteLine("State : " + Detailing.State);
                    Console.WriteLine("City : " + Detailing.City);
                    Console.WriteLine("Zip Code : " + Detailing.ZipCode);
                    Console.WriteLine("Phone number = " + Detailing.PhoneNumber);
                }
            }
        }

        public static void SortByFirstName(List<PersonsDetails> person)
        {
            contacts = person.OrderBy(p => p.FirstName).ToList();
            Console.WriteLine();
        }

        public void SortByChoice(List<PersonsDetails> contactDetails)
        {
            Console.WriteLine("Select the option to sort the contct list : \n1 : City Name \n2 : State Name \n3. Zip Code");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                contacts = contactDetails.OrderBy(p => p.City).ToList();
            }
            if (num == 2)
            {
                contacts = contactDetails.OrderBy(p => p.State).ToList();
            }
            if (num == 3)
            {
                contacts = contactDetails.OrderBy(p => p.ZipCode).ToList();
            }
            else
            {
                Console.WriteLine("Invalid Selection,please select between 1 to 3 ");
            }
        }
    }
}
