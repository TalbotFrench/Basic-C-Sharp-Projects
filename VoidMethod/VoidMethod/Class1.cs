using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    public class Thing
    {
        public void Stuff(int a, int b)
        {
            int ar = a / 2;
            Console.WriteLine(b);
            return;
        }
    }
}
