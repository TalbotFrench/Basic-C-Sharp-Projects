using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Thing stuff = new Thing();
            int a = 5;
            int b = 7;
            int Resultb = stuff.Stuff(a: a, b: b);
            Console.WriteLine(Resultb);

        }

    }
}
