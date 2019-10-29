using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance");
            Console.WriteLine("What is your age?");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Respond with True or False");
            string dui = Console.ReadLine();
            bool duiAnswer = Convert.ToBoolean(dui);

            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            bool qualified = Age >= 15 && dui == "False" && tickets <= 3;
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
