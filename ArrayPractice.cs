using System;
using System.Collections.Generic;




    class Program
    {
        static void Main()
        {
        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);

        Console.WriteLine(intList[0]);
        Console.ReadLine();





        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };
        //numArray2[5] = 650;
        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();

        Console.WriteLine("Choose an index from 0 to 4 to recieve a phrase.");
        string[] stuffArray = { "hello lil guy", "these are things I wrote", "in order for you to choose there has to be a choice", "isnt it wild?", "how things just keep happening?" };
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice > 4)
        {
            Console.WriteLine("Choose a number between 0 and 4");
        }

        Console.WriteLine(stuffArray[choice]);

        Console.WriteLine("Choose an integer between 0 and 8");
        int[] numbs = { 5, 76, 34, 56, 54, 89, 76, 1234, 90 };
        int numbsChoice = Convert.ToInt32(Console.ReadLine());
        if (choice > 8)
        {
            Console.WriteLine("Choose a number between 0 and 8");
        }

        Console.WriteLine(numbs[numbsChoice]);

        Console.WriteLine("Select an index of 1 through 3");
        List<string> sList = new List<string>();
        sList.Add("kame");
        sList.Add("hame");
        sList.Add("HA!");
        int sChoice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(sList[sChoice]);
        
        Console.ReadLine();
    }
    }


