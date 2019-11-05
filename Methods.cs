using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Math wack = new Math();
            Console.WriteLine("Please input a number you want to add");

            
            int num1 = Convert.ToInt32(Console.ReadLine());
            int AddResult = wack.Add(num1);
            Console.WriteLine("Your result is: {0}", AddResult);
            Console.ReadLine();


            Console.WriteLine("Please input a number you want to subtract");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int SubResult = wack.Sub(num2);
            Console.WriteLine("Your result is: {0}", SubResult);
            Console.ReadLine();

            Console.WriteLine("Please input a number you want to Multiply");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int MultiResult = wack.Multi(num3);
            Console.WriteLine("Your result is: {0}", MultiResult);
            Console.ReadLine();


         
            Console.ReadLine();
        }
        
    }
}
