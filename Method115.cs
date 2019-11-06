using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    public class Method       
    {
        
            
        public int AddNumbers(int numA, int numB = 0)
        {
            return numA + numB;
           
        }

    }
}
