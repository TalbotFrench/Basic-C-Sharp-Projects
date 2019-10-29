using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)

        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //    Console.ReadLine();

            //   int pro = 10 * 5;
            //Console.WriteLine(pro);
            //   Console.ReadLine();


            //int quo = 100 / 5;
            //Console.WriteLine(quo);
            //Console.ReadLine();

            //int remain = 11 % 2;
            //Console.WriteLine(remain);
            //Console.ReadLine();

            //bool tOrF = 12 < 5;
            //Console.WriteLine(tOrF.ToString());
            //Console.ReadLine();

            //int roomTep = 70;
            //int currentTep = 72;

            //bool isWarm = currentTep > roomTep;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();


            Console.WriteLine("Enter a number...");
             int FirstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FirstNum * 50);
            Console.WriteLine(FirstNum + 25);
            Console.WriteLine(FirstNum / 12.5);
            bool great = FirstNum > 50;
            Console.WriteLine(great);
            int SecondNum = FirstNum / 7;
            Console.WriteLine(SecondNum % 2);
            Console.ReadLine();


        }
    }
}
