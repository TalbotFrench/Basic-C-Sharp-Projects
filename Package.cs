using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the specifications of your package.");
            Console.WriteLine("How much does the package weigh?");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How Wide is the Package?");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the Height of the Package?");
            int Height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the Length of the Package?");
            int Length = Convert.ToInt32(Console.ReadLine());

            int SumDimension = width + Height + Length;
            if (SumDimension > 50)
            {
                Console.WriteLine("Your package is too big.");
            }
            else
            {
                int clac = (SumDimension * weight) / 100;
                Console.WriteLine("Your estiamted total for shipping this package is : $" + clac);
                Console.WriteLine("Thank you.");
                Console.ReadLine();
            }
        }
    }
}
