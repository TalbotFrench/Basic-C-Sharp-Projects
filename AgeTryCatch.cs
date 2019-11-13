using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeBorn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is you age?");
            int age = Convert.ToInt32(Console.ReadLine());
            int year = 2019 - age;
            while (age < 0 && age > 120)
            {
                try {
                    
                    Console.WriteLine("you were born in the year " + year);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("thats not your age!" + e.GetType());
                    Console.ReadLine();
                    throw;
                }
                catch (InvalidCastException)
                {
                    Console.WriteLine("Invalid.");
                    return;
                }

            }
            Console.ReadLine();
        }
    }
}
