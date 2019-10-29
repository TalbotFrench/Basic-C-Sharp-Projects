using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anontmous_income_comparison_program
{
    class Program
    {
        static void Main(string[] args)
         
        {


            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1:");
            Console.WriteLine("Hourly Rate");
            int perOneHour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week:");
            int perOneweek = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2:");
            Console.WriteLine("Hourly Rate");
            int perTwoHour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week:");
            int perTwoweek = Convert.ToInt32(Console.ReadLine());

            int weeklyOne = perOneHour * perOneweek;
            int weeklyTwo = perTwoHour * perTwoweek;

            Console.WriteLine("Weekly salary of Person 1: " + weeklyOne);
            Console.WriteLine("Weekly salary of Person 2: " + weeklyTwo);

            bool makeMore = weeklyOne > weeklyTwo;
            Console.WriteLine(makeMore);
            Console.ReadLine();
        }
    }
}
