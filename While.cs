using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _94Proj
{
    class Program
    {
        static void Main()
        {
            var result = "";
            var i = 5;
            do
            {
                i = i - 1;
                result = result + i + " tries.";
                bool Gender = false;
                while (Gender == false)
                {
                    Console.Write("Enter your Gender: ");  // Asks for your name
                    string myGender = Console.ReadLine();
                    if (myGender == "Male")
                    {
                        Console.WriteLine("You are a Male");
                        Gender = true;
                    }

                    else if (myGender == "Female")
                    {
                        Console.WriteLine("You are a Female");
                        Gender = true;

                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a valid gender.");
                        Gender = false;

                    }
                    Console.ReadLine();
                }



            } while (i > 0);
            Console.WriteLine(result);
        }
    }
}
