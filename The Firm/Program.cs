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
            Employee e1 = new Manager("bob", "nielsen", 12345678, 12341234);
            Employee e2 = new Projectmanager("test", "test", 123123, 123123, "manager@mail.com.co");
            Employee e3 = new Sweeper("tester", "tester", 12341234);
            Employee e4 = new Employee("tester2", "tester2", 1234124123);

            e1.GetData();
            e2.GetData();
            e3.GetData();
            e4.GetData();
            Console.ReadLine();

        }
    }
}
