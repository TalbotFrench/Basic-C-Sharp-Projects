using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees129
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Talbot = new Employee();
            Employee employee2 = new Employee();

            Talbot.Id = 0001;
            Talbot.Name = "Talbot";

            employee2.Id = 0002;
            employee2.Name = "Benhem";

            bool isEmployee = Talbot == employee2;

            Console.WriteLine("Does " + Talbot.Name + " and " + employee2.Name + "s employee Ids match? " + isEmployee);
            Console.ReadLine();
        }
    }
}
