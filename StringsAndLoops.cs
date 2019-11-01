using System;
using System.Collections.Generic;



    class Program
    {
        static void Main(string[] args)
        {
        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine("Passing test score " + testScores[i]);
        //    }
        //}
        //Console.ReadLine();

        //string[] names = { "Erick", "Jesse", "Rob", "Rod", "Adam" };

        //for (int j = 0; j < names.Length; j++)
        //{
        //    Console.WriteLine(names[j]);
        //}

        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(70);

        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passing Test Score " + score);


        //    }
        //}



        //THIS IS THE PROJECT!
        //Console.WriteLine("Enter Information as prompted.");
        //Console.WriteLine("Enter the name of a country.");
        //string cun = Console.ReadLine();
        //Console.WriteLine("Write the name of a state or provence");
        //string state = Console.ReadLine();
        //Console.WriteLine("Enter the name of a city.");
        //string city = Console.ReadLine();
        //Console.WriteLine("Enter the name of a street.");
        //string street = Console.ReadLine();
        //Console.WriteLine("Enter an address.");
        //string address = Console.ReadLine();

        //string[] stringAr = {cun, state, city, street, address };

        //for(int i = 1; i<1; i++)
        //{
        //    Console.WriteLine(stringAr[i]);
        //}

        //for (int i = 1; i < 1; i++)
        //{
        //       Console.WriteLine(i);
        //}
        //for (int k = 0; k <= 1; k++)
        //{
        //    Console.WriteLine(k);
        //}

        List<String> Colors = new List<String>();
        Colors.Add("Red");
        Colors.Add("Blue");
        Colors.Add("Yellow"); 
        Colors.Add("Black");
        Colors.Add("White");
        Colors.Add("Orange");
        Colors.Add("Purple");
        Console.WriteLine("Enter a Color");
        string userSelect = Console.ReadLine();
        
        
        for (int j = 0; j < 6; j++)
        {
            if (userSelect == Colors[j])
            {
                break;
            }
            
        Console.WriteLine(Colors[j]);
        } 
            if (Colors.Contains(userSelect))
            {Console.WriteLine("Color Found");
                
            }
            else
            {
                Console.WriteLine("Input Another color");
            }


        List<String> Animals = new List<String>();
        Colors.Add("Cat");
        Colors.Add("Dog");
        Colors.Add("Gecko");
        Colors.Add("Lion");
        Colors.Add("Horse");
        Colors.Add("Bird");
        Colors.Add("Bear");
        Colors.Add("Horse");
        Console.WriteLine("Enter an Animal");
        string userAnimal = Console.ReadLine();

        for (int l = 0; l < 7; l++)
        {
            
            
            if (userAnimal == Colors[l])
            {
                break;
            }
            else
            {
                Console.WriteLine("Input Another Animal");
            }

            Console.WriteLine(Colors[j]);
        }











        Console.ReadLine();
        }
    }

