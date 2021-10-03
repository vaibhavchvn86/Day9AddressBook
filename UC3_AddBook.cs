using System;
using System.Collections.Generic;
using System.Text;

namespace Day9AddressBook
{
    class UC3_AddBook
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double MobileNumber { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public double Zipcode { get; set; }
        public string Email { get; set; }

        public static List<UC3_AddBook> ContactDetail = new List<UC3_AddBook>();
        public static void AddBook1()
        {
            UC3_AddBook person = new UC3_AddBook();

                Console.Write("Enter FirstName: ");
                person.FirstName = Console.ReadLine();

                Console.Write("Enter LastName: ");
                person.LastName = Console.ReadLine();

                Console.Write("Enter Mobile Number: ");
                person.MobileNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Address : ");
                person.Address = Console.ReadLine();

                Console.Write("Enter State : ");
                person.State = Console.ReadLine();

                Console.Write("Enter ZipCode : ");
                person.Zipcode = Convert.ToDouble(Console.ReadLine());

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
            ////To edit The Entry
            Console.WriteLine("Choose Entry To Edit in AddressBook \n1.FirstName, \n2.LastName,\n3.Address\n4.MobileNumber\n5.Email\n6.Zipcode");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    //Console.WriteLine("Enter FirstName For edit");
                    //var Edit1 = Console.ReadLine();
                    //var editobj1 = ContactDetail.Find(x => x.FirstName == Edit1);
                    Console.WriteLine("Enter New FirstName; ");
                    person.FirstName = Console.ReadLine();
                    ContactDetail.Add(person);
                    Console.WriteLine("First Name: " + person.FirstName);
                    break;
                case 2:
                    //Console.WriteLine("Enter LastName For edit");
                    //var Edit2 = Console.ReadLine();
                    //var editobj2 = ContactDetail.Find(x => x.LastName == Edit2);
                    Console.WriteLine("Enter New LastName; ");
                    person.LastName = Console.ReadLine();
                    ContactDetail.Add(person);
                    Console.WriteLine("Last Name: " + person.LastName);
                    break;
                case 3:
                    //Console.WriteLine("Enter Address For edit");
                    //var Edit3 = Console.ReadLine();
                    //var editobj3 = ContactDetail.Find(x => x.Address == Edit3);
                    Console.WriteLine("Enter New Address; ");
                    person.Address = Console.ReadLine();
                    ContactDetail.Add(person);
                    Console.WriteLine("Address: " + person.Address);
                    break;
                case 4:
                    //Console.WriteLine("Enter MobileNumber For edit");
                    //var Edit4 = Convert.ToDouble(Console.ReadLine());
                    //var editobj4 = ContactDetail.Find(x => x.MobileNumber == Edit4);
                    Console.WriteLine("Enter New MobileNumber; ");
                    person.MobileNumber = Convert.ToDouble(Console.ReadLine());
                    ContactDetail.Add(person);
                    Console.WriteLine("MobileNumber: " + person.MobileNumber);
                    break;
                case 5:
                    //Console.WriteLine("Enter Email For edit");
                    //var Edit5 = Console.ReadLine();
                    //var editobj5 = ContactDetail.Find(x => x.Email == Edit5);
                    Console.WriteLine("Enter New Email; ");
                    person.Email = Console.ReadLine();
                    ContactDetail.Add(person);
                    Console.WriteLine("Email: " + person.Email);
                    break;
                case 6:
                    Console.WriteLine("Enter ZipCode For edit");
                    var Edit6 = Convert.ToDouble(Console.ReadLine());
                    var editobj6 = ContactDetail.Find(x => x.Zipcode == Edit6);
                    Console.WriteLine("Enter New ZipCode; ");
                    person.Zipcode = Convert.ToDouble(Console.ReadLine());
                    ContactDetail.Add(person);
                    Console.WriteLine("ZipCode: " + person.Zipcode);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Mobile Number: " + person.MobileNumber);
            Console.WriteLine("Address : " + person.Address);
            Console.WriteLine("State : " + person.State);
            Console.WriteLine("ZipCode : " + person.Zipcode);
            Console.WriteLine("Email : " + person.Email);
            Console.WriteLine("-------------------------------------------");
        }
    }
}