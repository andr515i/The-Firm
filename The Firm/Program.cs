using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            // here we make an instance of all the different types of employees
            // as i see them all as employees atleast, they all need a first and last name and a phonenumber

            Employee e4 = new Employee("first", "last", 1233123);
            Employee e3 = new Sweeper("first", "last", 12341234);
            Employee e1 = new Manager("firstname", "lastname", 12345678, 12341234);
            Employee e2 = new Projectmanager("firstname", "lastname", 123123, 123123, "manager@mail.com.co");

            // reverse calling to make it easier to see
            // down here i call all their respective getdata methods to print out data
            e4.GetData();
            e3.GetData();
            e1.GetData();
            e2.GetData();

            
            Console.ReadLine();

        }
    }
}
