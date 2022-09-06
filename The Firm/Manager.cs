using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm
{
    internal class Manager : Employee
    {
        private protected int phoneNumber;

        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public Manager(string firstName, string lastName, int cprNumber, int phoneNumber):base(firstName, lastName, cprNumber)
        {
            this.phoneNumber = phoneNumber;
        }
        internal virtual void GetData()
        {
            Console.WriteLine(this.firstName + " " + this.lastName + " " + this.cpr + " " + this.phoneNumber);
        }
    }
}
