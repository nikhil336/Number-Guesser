using System;

// Namespace
namespace NumberGuesser
{
    // Main Program
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo Function
            GreetUser(); // Ask for users name and greet
            StartGame(); // Start Game
        }

        // Get and display info
        static void GetAppInfo()
        {
            //Set App vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string author = "Nikhil Rana";
            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;
            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, author);
            // Reset text color
            Console.ResetColor();
        }

        //Ask user name and greet
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");
            // Get user input
            string inputName = Console.ReadLine();
            // Print hello message
            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;
            // Tell user its not a number
            Console.WriteLine(message);
            //Reset Text color
            Console.ResetColor();
        }

        // Function to start game
        static void StartGame()
        {
            while (true)
            {
                //Create Random class object
                Random random = new Random();
                //Set random number between 1 to 10 to correctNumber
                int correctNumber = random.Next(1, 11);
                //Set guess number
                int guess = 0;
                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get user input
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                //Print success message
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!!");
                //Ask to play again
                Console.WriteLine("Play Again? [Y or N]");
                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
    }
}
