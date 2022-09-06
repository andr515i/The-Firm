using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm
{
    class Employee
    {
        private protected string firstName;

        public string FirstName
        {
            get { return firstName; }
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

        public Employee(string firstName, string lastName, int cprNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.cpr = cprNumber;
        }
        internal virtual void GetData()
        {
            Console.WriteLine(this.firstName + " " + this.lastName + " " + this.cpr);
        }
    }
}
