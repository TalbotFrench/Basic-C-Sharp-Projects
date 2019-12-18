using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _117try2
{
    class DivideByTwo
    {
        public void Divide(int numA)
        {
            int numB = (numA / 2);
            Console.WriteLine(numB);
        }

        public void Divide(int numA, int numB)
        {
            int result = (numA + numB) / 2;

        }


        public static int numG;
        public  void Plain(out int numG)
        {
            numG = 10;
            
        }
    }
}

