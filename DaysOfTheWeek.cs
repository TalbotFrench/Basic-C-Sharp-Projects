using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Please enter a day of the week:");
            string userInput = Console.ReadLine();



            try
            {
                userInput == Enum.TryParse());


            }
            catch (InvalidCastException e){
                Console.WriteLine("Please enter a valid day");
            }

            
        }
        public enum Days
        {
            Monday,
            Tuesday,
            Wensday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        
    }
}
