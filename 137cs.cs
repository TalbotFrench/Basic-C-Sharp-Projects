using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number(5);

            Console.WriteLine(num);

      

        }
        public struct Number {
            public decimal Amount(decimal a);
        }

}
}
