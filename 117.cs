using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _117
{
    class Program
    {
        private static void Main(string[] args)
        {
            DivideByTwo div = new DivideByTwo();

            Console.WriteLine("Enter a number");
            int A = Convert.ToInt32(Console.ReadLine());
            div.Divide(numA: A);
            

            Console.WriteLine("Enter another number");
            int B = Convert.ToInt32(Console.ReadLine());
            div.Divide(numA: A, numB: B);
            
            

            

            Console.ReadLine();

        }
    }
}
