using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm
{
    sealed class Projectmanager : Manager  // projectmanager -> manager -> employee
    {
        private string email;

        public string Email
        {
            get { return email; }
        }

        // this time we add email aswell to the manager's ctor
        public Projectmanager(string firstName, string lastName, int cprNumber, int phoneNumber, string email) : base(firstName, lastName, cprNumber, phoneNumber)
        {
            this.email = email;


        }

        // and print it  out
        protected internal override void GetData()
        {
            Console.WriteLine(this.firstName + " " + this.lastName + " " + this.cpr + " " + this.phoneNumber + " " + this.email);
        }

    }
}
