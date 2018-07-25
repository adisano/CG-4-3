using System;

namespace NameLottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program can select a winner randomly from out of up to 30 names.");
            Console.WriteLine("Please begin entering names to choose from. Press ENTER after each name or once you are finished.");

            string[] namesList = new string[30];

            Random namesRandomizer = new Random();

            //accept 30 names
            for (int namesLimit = 0; namesLimit < 30; namesLimit++)
            {

                //add names to array
                string namesNew = Console.ReadLine();
                namesList[namesLimit] = namesNew;

                //choose and display random name, all entries
                if (namesNew == "")
                {
                    int namesWinner = namesRandomizer.Next(namesLimit);
                    Console.WriteLine("The winning name is " + namesList[namesWinner] + "!");
                    Console.WriteLine("Thank you to everyone who entered:");
                    foreach (string namesLosers in namesList)
                    {
                        Console.WriteLine(namesLosers);
                    }
                }
                else
                {
                    if (namesLimit < 29)
                    {
                        Console.WriteLine("Name " + (namesLimit + 1) + " is " + namesNew + ". Please continue entering names or press ENTER to finish.");

                    }
                    else
                    {
                        Console.WriteLine("Name " + (namesLimit + 1) + " is " + namesNew + ". The list of names is now full.");
                    }
                }

                
            }
            Console.ReadLine();

        }
    }
}
