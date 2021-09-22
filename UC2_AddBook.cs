using System;
using System.Collections.Generic;
using System.Text;

namespace Day9AddressBook
{
    class UC2_AddBook
    {
        ublic string FirstName;
        public string LastName;
        public string MobileNumber;
        public string Address;
        public string State;
        public string Zipcode;
        public string Email;

        public static List<UC2_AddBook> ContactDetail = new List<UC2_AddBook>();
        public static void AddPerson()
        {
            UC2_AddBook person = new UC2_AddBook();
            Console.Write("Enter Number AddressBook Id to be Created: ");
            int N= Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("AddressBook ID=" + (100 + i));

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

                //ContactDetail.Add(person);

                Console.WriteLine("First Name: " + person.FirstName);
                Console.WriteLine("Last Name: " + person.LastName);
                Console.WriteLine("Mobile Number: " + person.MobileNumber);
                Console.WriteLine("Address : " + person.Address);
                Console.WriteLine("State : " + person.State);
                Console.WriteLine("ZipCode : " + person.Zipcode);
                Console.WriteLine("Email : " + person.Email);
            }
        }
    }
}
