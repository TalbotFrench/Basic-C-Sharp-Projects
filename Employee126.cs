using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullName
{
    public class Employee : Person, IQuittable
    {

        Person p = new Person("Sample", "Student");
        Console.WriteLine(p.SayName());
        int id = 0001;

        void Quit(string a)
        {
            string a = "You quit!";
            Console.WriteLine(a);
        }

        void Quit(string a, int b)
        {
            string a = "You quit";
            Console.WriteLine(a + b +" times");
        }


    }
}
