using System;
using System.Collections.Generic;
using System.Text;

namespace Day9AddressBook
{
    class UC2_AddBook
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Email { get; set; }

        public static List<UC2_AddBook> ContactDetail = new List<UC2_AddBook>();
        public static void AddPerson()
        {
            UC2_AddBook person = new UC2_AddBook();
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
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Mobile Number: " + person.MobileNumber);
            Console.WriteLine("Address : " + person.Address);
            Console.WriteLine("State : " + person.State);
            Console.WriteLine("ZipCode : " + person.Zipcode);
            Console.WriteLine("Email : " + person.Email);
            Console.WriteLine("-------------------------------------------");
            ////edit 1 or more Entries
            Console.Write("Do You Want to Create New Contact? (Y/N): ");
            string N = Convert.ToString(Console.ReadLine());
            while (N == "y" || N == "Y")
            {
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
                Console.WriteLine("First Name: " + person.FirstName);
                Console.WriteLine("Last Name: " + person.LastName);
                Console.WriteLine("Mobile Number: " + person.MobileNumber);
                Console.WriteLine("Address : " + person.Address);
                Console.WriteLine("State : " + person.State);
                Console.WriteLine("ZipCode : " + person.Zipcode);
                Console.WriteLine("-------------------------------------------");

                Console.Write("Do You Want to Create New Contact? (Y/N): ");
                N = Convert.ToString(Console.ReadLine());
            }
        }
    }
}
