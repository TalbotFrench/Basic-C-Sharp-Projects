using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextLog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\talbo\logs\log.txt", true))
            {
                file.WriteLine(num);
            }
            Console.WriteLine(num);
        }
    }
}
