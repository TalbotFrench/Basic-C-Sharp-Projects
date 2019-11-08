using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullName
{
    public class Employee : Person, IQuittable
    {
        public void SayName()
        {
            Console.WriteLine("Name: " + firstName + "" + lastName);
            Console.ReadLine();
        }
        

        void Quit()
        {
            Console.WriteLine("You Quit");
            Console.ReadLine();
        }
}
}
