using System;
using System.Collections.Generic;
using System.Text;

namespace Day9AddressBook
{
    class UC3_AddBook
    {
        public string FirstName;
        public string LastName;
        public string MobileNumber;
        public string Address;
        public string State;
        public string Zipcode;
        public string Email;

        public static List<UC3_AddBook> ContactDetail = new List<UC3_AddBook>();
        public static void AddBook1()
        {
            int AddB=100;
            UC3_AddBook person = new UC3_AddBook();
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
            Console.WriteLine("AddressBook ID To edit");
            int ID = Convert.ToInt32(Console.ReadLine());
            if (ID == AddB)
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
                Console.WriteLine("Address Book updated Successfully ");
                Console.WriteLine("AddressBook ID= " + AddB);
                Console.WriteLine("First Name: " + person.FirstName);
                Console.WriteLine("Last Name: " + person.LastName);
                Console.WriteLine("Mobile Number: " + person.MobileNumber);
                Console.WriteLine("Address : " + person.Address);
                Console.WriteLine("State : " + person.State);
                Console.WriteLine("ZipCode : " + person.Zipcode);
                Console.WriteLine("Email : " + person.Email);
            }
            else
            {
                Console.WriteLine("Enter AddressBook Id is Invalid");
            }
        }
    }
}