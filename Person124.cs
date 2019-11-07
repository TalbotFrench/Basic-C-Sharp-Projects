using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullName
{
    public abstract class Person

    {
        public string FirstName;
        public string LastName;

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            return;

        
        
        }
        public void SayName()
        {
            string fullName = FirstName+ " " + LastName;
        }
        
        
    }
}
