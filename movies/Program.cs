using System;
using System.Collections.Generic;

namespace movies
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> Genres = new List<string>();
            Genres.Add("Comedy");
            Genres.Add("Action");
            Genres.Add("Romance");

            List<string> Comedys = new List<string>();
            Comedys.Add("Shawshank Redemption");
            Comedys.Add("Happy Gilmore");
            Comedys.Add("Monty Python & The Holy Grail");

            List<string> Romances = new List<string>();
            Romances.Add("Shawshank Redemption");
            Romances.Add("The Notebook");
            Romances.Add("Titanic");

            List<string> Actions = new List<string>();
            Actions.Add("Die Hard");
            Actions.Add("Die Hard: 2");
            Actions.Add("Die Hard: With Vengence");
            do
            {
                Console.WriteLine("Hello World! I know some movies... Pick a genre and I'll tell you some movies.");
                Console.WriteLine("1. " + Genres[0]);
                Console.WriteLine("2. " + Genres[1]);
                Console.WriteLine("3. " + Genres[2]);
                string userInputGenre = Console.ReadLine();

                if (userInputGenre == "1")
                {
                    foreach (string x in Comedys)
                    {
                        Console.WriteLine(x);
                    }
                }
                else if (userInputGenre == "2")
                {
                    foreach (string x in Actions)
                    {
                        Console.WriteLine(x);
                    }
                }
                else if (userInputGenre == "3")
                {
                    foreach (string x in Romances)
                    {
                        Console.WriteLine(x);
                    }
                }
                else
                {
                    Console.WriteLine("You suck user");
                }
            }
            while (ShouldContinue());


        }
        public static bool ShouldContinue()
        {
            Console.WriteLine("Do you want to try again? Press Y to continue or any other key to quit");
            ConsoleKeyInfo keyPressed = Console.ReadKey();

            if (keyPressed.Key == ConsoleKey.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
