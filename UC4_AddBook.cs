using System;
using System.Collections.Generic;
using System.Text;

namespace Day9AddressBook
{
    class UC4_AddBook
    {
        public string FirstName;
        public string LastName;
        public string MobileNumber;
        public string Address;
        public string State;
        public string Zipcode;
        public string Email;
        public static List<UC4_AddBook> ContactDetail = new List<UC4_AddBook>();
        public static void AddBook2()
        {
            int AddB = 100;
            UC4_AddBook person = new UC4_AddBook();
            Console.Write("Enter Number AddressBook Id to be Created: ");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                AddB = AddB + i;

                Console.Write("Enter FirstName: ");
                person.FirstName = Console.ReadLine();

                Console.Write("Enter LastName: ");
                person.LastName = Console.ReadLine();

                Console.Write("Enter Mobile Number: ");
                person.MobileNumber = Console.ReadLine();

                Console.Write("Enter Address : ");
                person.Address = Console.ReadLine();

                Console.Write("Enter State : ");
                person.State = Console.ReadLine();

                Console.Write("Enter ZipCode : ");
                person.Zipcode = Console.ReadLine();

                Console.Write("Enter Email : ");
                person.Email = Console.ReadLine();

                ContactDetail.Add(person);

                Console.WriteLine("AddressBook ID= " + AddB);

                Console.WriteLine("First Name: " + person.FirstName);
                Console.WriteLine("Last Name: " + person.LastName);
                Console.WriteLine("Mobile Number: " + person.MobileNumber);
                Console.WriteLine("Address : " + person.Address);
                Console.WriteLine("State : " + person.State);
                Console.WriteLine("ZipCode : " + person.Zipcode);
                Console.WriteLine("Email : " + person.Email);
                Console.WriteLine("-------------------------------------------");


            }
            //To edit The Entry
            Console.WriteLine("AddressBook ID To Delete");
            int ID = Convert.ToInt32(Console.ReadLine());
            if (ID == AddB)
            { 
                Console.WriteLine("Are you sure you want to remove address book? (Y/N)");

                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    ContactDetail.Remove(person);
                    Console.WriteLine("AddressBook "+AddB+"  Deleted. Press any key to continue.");
                    Console.WriteLine("AddressBook ID= " + AddB);
                    Console.WriteLine("First Name: " + person.FirstName);
                    Console.WriteLine("Last Name: " + person.LastName);
                    Console.WriteLine("Mobile Number: " + person.MobileNumber);
                    Console.WriteLine("Address : " + person.Address);
                    Console.WriteLine("State : " + person.State);
                    Console.WriteLine("ZipCode : " + person.Zipcode);
                    Console.WriteLine("Email : " + person.Email);
                    Console.WriteLine("-------------------------------------------");
                    Console.ReadKey();
                }
            }
        }
    }
}
