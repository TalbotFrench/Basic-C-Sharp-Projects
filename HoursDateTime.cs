using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("Please input a number");
            int hours = Convert.ToInt32(Console.ReadLine());
            DateTime dateTime = new DateTime(2019, 11, 12, hours, 6, 30);



        }
    }
}
