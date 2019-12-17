using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _117
{
    public class DivideByTwo
    {
        public void Divide(int numA)
        {
           numA = numA / 2;
            
        }

        public void Divide(int numA, int numB)
        {
            int result = (numA + numB ) / 2;
            
        }


        public static int numG;
        static void Plain()
        {
            numG = 10;
            Console.WriteLine(numG);
        }
    }


}
