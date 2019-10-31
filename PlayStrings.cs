using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringsOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said, \\Hello\", Jesse. \n Hello on a new line \n \t Hello on a tab.";
            //string fileName = @"C:\Users\Jesse";


            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();

            //Console.WriteLine(length);
            //Console.ReadLine();

            //StringBuilder sb = new StringBuilder();

            //sb.Append("my name is jesse");

            //Console.WriteLine(sb);
            //Console.ReadLine();



            Console.WriteLine("Type your name here");
             string userName = Console.ReadLine();
            string dateString = DateTime.Today.ToShortDateString();

            
            string str = "Hello " + userName + ". Today is " + dateString + ".";
            Console.WriteLine(str);

            str += " How are you today?";
            Console.WriteLine(str);
            Console.ReadLine();

            string wack = "wack";
            Console.WriteLine(wack.ToUpper());
            

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Here is my story lil guy!");
            sb.AppendLine("I was a boy of a mere 8 years,");
            sb.AppendLine("constantly surrounded by critical leers");
            sb.AppendLine("never was prone to tears,");
            sb.AppendLine("and I quickly learned to conquer my fears.");
            Console.WriteLine(sb);
            Console.ReadLine();





        }
    }
}
