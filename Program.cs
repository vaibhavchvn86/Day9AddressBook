using System;

namespace Day9AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Welcome To Address Book Program****");
            //#region UC1
            //UC1_AddBook Contact =new UC1_AddBook("Sham","Roy","High Street","Mumbai","Maharashtra", 400001, 9182736455,"sham.roy@email.com");
            //Console.WriteLine(Contact.toString());
            //#endregion

            #region UC2
            UC2_AddBook.AddPerson();
            #endregion
        }
    }
}
