using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm
{
    class Projectmanager : Manager
    {
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public Projectmanager(string firstName, string lastName, int cprNumber, int phoneNumber, string email) : base(firstName, lastName, cprNumber, phoneNumber)
        {
            this.email = email;
        }
        internal virtual void GetData()
        {
            Console.WriteLine(this.firstName + " " + this.lastName + " " + this.cpr + " " + this.phoneNumber + " " + this.email);
        }

    }
}
