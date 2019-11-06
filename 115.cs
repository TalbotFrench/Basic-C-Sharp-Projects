using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Method math = new Method();
            Console.WriteLine("Enter a number.");
            int numA = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter a second number if you desire.");
            string numB = Console.ReadLine();

            int a;
            if (Int32.TryParse(numB, out a))
            {

                Console.WriteLine(math.AddNumbers(numA, a));
            }
            else
            {
                Console.WriteLine(math.AddNumbers(numA));
            }
            Console.ReadLine();

        }
    }
}
