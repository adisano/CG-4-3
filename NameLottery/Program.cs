using System;

namespace NameLottery
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user for input
            Console.WriteLine("This program can select a winner randomly from out of up to 30 names.");
            Console.WriteLine("Please begin entering names to choose from. Press ENTER after each name or once you are finished.");

            //initialize an array for names
            string[] namesList = new string[30];

            //initialize a random seed
            //this is for picking a winner
            Random namesRandomizer = new Random();

            //iterate through this loop up to 30 times
            //this is for adding names to the raffle
            for (int namesLimit = 0; namesLimit < 30; namesLimit++)
            {

                //prompt user for names and add them to the array
                string namesNew = Console.ReadLine();
                namesList[namesLimit] = namesNew;

                //execute if the user presses enter without typing any input
                if (namesNew == "")
                {
                    //assign value to an integer according to random seed
                    int namesWinner = namesRandomizer.Next(namesLimit);
                    //display the winner and all entrants
                    Console.WriteLine("The winning name is " + namesList[namesWinner] + "!");
                    Console.WriteLine("Thank you to everyone who entered:");
                    foreach (string namesLosers in namesList)
                    {
                        Console.WriteLine(namesLosers);
                    }
                    break;
                }
                else
                {
                    //displays name entered and gives user further instructions
                    if (namesLimit < 29)
                    {
                        Console.WriteLine("Name " + (namesLimit + 1) + " is " + namesNew + ". Please continue entering names or press ENTER to finish.");

                    }
                    //displays name entered, tells the user this was the last name they can enter
                    else
                    {
                        Console.WriteLine("Name " + (namesLimit + 1) + " is " + namesNew + ". The list of names is now full.");
                    }
                }

                
            }
            //await input before closing program
            Console.ReadLine();

        }
    }
}
