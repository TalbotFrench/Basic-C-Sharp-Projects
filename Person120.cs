using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullName
{
    public class Person
    {
        string firstName = "Sample";
        string lastName = "Student";
        
        public void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
