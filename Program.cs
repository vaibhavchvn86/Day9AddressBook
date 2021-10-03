using System;
using System.Collections.Generic;

namespace Day9AddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("****Welcome To Address Book Program****");

            #region UC1
            UC1_AddBook.Contact();
            #endregion

            #region UC2
            UC2_AddBook.AddPerson();
            #endregion

            #region UC3
            UC3_AddBook.AddBook1();
            #endregion

            #region UC4
            UC4_AddBook.AddBook2();
            #endregion

            Console.ReadKey();
        }
    }
}

