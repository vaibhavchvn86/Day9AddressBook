using System;
using System.Collections.Generic;
using System.Text;

namespace Day9AddressBook
{
   public class UC1_AddBook
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public int Zipcode;
        public double PhoneNum;
        public string Email;
        public UC1_AddBook(string FirstName, string LastName, string Address, string City, string State, int Zipcode, double PhoneNum, string Email)
        {

            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.Zipcode = Zipcode;
            this.PhoneNum = PhoneNum;
            this.Email = Email;
        }
        public string toString()
        {
            return "Contact Detials:\n" +"FirstName:\t"+ this.FirstName +"\n"+"LastName:\t" + this.LastName +"\n" + "Address:\t" + this.Address + "\n" + "City:\t" + this.City + "\n" + "State:\t" + this.State + "\n" + "Zipcode:\t" + this.Zipcode + "\n" + "Phonenumber:\t" + this.PhoneNum + "\n" + "Email:\t" + this.Email;
        } 
    }
}
