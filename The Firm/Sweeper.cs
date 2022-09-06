using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm
{
    sealed class Sweeper: Employee
    {  // inherits from employee, but we dont actually need anything additional, so this class is empty for now
        public Sweeper(string firstName, string lastName, int cprNumber) : base(firstName, lastName, cprNumber)
        {
        }
        
    }
}
