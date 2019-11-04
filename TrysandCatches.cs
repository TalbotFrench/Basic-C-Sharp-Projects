using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrysAndCatches
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> ints = new List<int>();
                ints.Add(6);
                ints.Add(16);
                ints.Add(26);
                ints.Add(36);
                ints.Add(46);

                Console.WriteLine("Please enter an integer to divide the list by");
                int div = Convert.ToInt32(Console.ReadLine());
                foreach (int element in ints)
                {
                    Console.WriteLine(element / div);
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please dont enter a string.");
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("please dont divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
