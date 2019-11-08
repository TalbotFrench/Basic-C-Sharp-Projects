using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullName
{
    class Program
    {
        static void Main(string[] args)
        {
           IQuittable empleado = new Employee();
            empleado.Quit();

            Console.ReadLine();
        }
    }
}
