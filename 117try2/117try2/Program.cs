using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _117try2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                DivideByTwo div = new DivideByTwo();

                Console.WriteLine("Enter a number");
                int A = Convert.ToInt32(Console.ReadLine());
                div.Divide(A);
                int c = 100;
                

                Console.WriteLine("Before method call, value of c: {0}", c);
                div.Plain(out c);
                Console.WriteLine("After method call, value of c: {0}", c);


                Console.WriteLine("Enter another number");
                int B = Convert.ToInt32(Console.ReadLine());
                div.Divide(numA: A, numB: B);   





                Console.ReadLine();

            }
        }
    }
}
