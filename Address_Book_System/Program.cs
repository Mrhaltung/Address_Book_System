using System;

namespace Address_Book_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********** Address Book Program ************\n");

            AddressBook.AddContact();
            AddressBook.Display();
            AddressBook.Edit();
            AddressBook.Display();
        }
    }
}
