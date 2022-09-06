using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm
{
    internal class Manager : Employee  // inherits employee
    {
        private protected int phoneNumber;

        public int PhoneNumber
        {
            get { return phoneNumber; }
        }

        // same story here, we inherit the values, and add phonenumber aswell
        public Manager(string firstName, string lastName, int cprNumber, int phoneNumber):base(firstName, lastName, cprNumber)
        {
            this.phoneNumber = phoneNumber;
        }
        protected internal override void GetData()  // and then we print it out
        {
            Console.WriteLine(this.firstName + " " + this.lastName + " " + this.cpr + " " + this.phoneNumber);
        }
    }
}
