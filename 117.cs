using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _117
{
    class Program
    {
        static void Main(string[] args)
        {
            DivideByTwo div = new DivideByTwo();

            Console.WriteLine("Enter a number");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(div.Divide(A));


        }
    }
}
