using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm
{
    class Employee
    {  // base class
        private protected string firstName;

        public string FirstName
        {
            get { return firstName; }  // we dont change names in this company
        }

        private protected string lastName;

        public string LastName
        {
            get { return lastName; }
        }

        private protected int cpr;

        public int Cpr
        {
            get { return cpr; }
        }

        public Employee(string firstName, string lastName, int cprNumber)  // ctor to get relevant data
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.cpr = cprNumber;
        }
        protected internal virtual void GetData()   // then we print it out via the virtual method, getdata
        {
            Console.WriteLine(this.firstName + " " + this.lastName + " " + this.cpr);
        }
    }
}
