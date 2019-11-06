using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Math math = new Math();
            int twelve = math.Add(12);
            Console.WriteLine(twelve);

            double div = math.Div(7.9);
            Console.WriteLine(div);

            string multi = Convert.ToInt32(math.Multi(5));
            Console.WriteLine(div);


        }
    }
}
