using System;

//Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            /* a little practice on C#
            string name = "Vivien Zeng";
            int age = 18;
            
            // START HERE //
            Console.WriteLine("{0} is {1} years old.",name,age);//{0},{1} are place holders
            */

            GetAppInfo(); // Run GetAppImfo function to get app info

            GreetUser(); // Ask for user name and greet

            while (true)
            {
                // Set correct number
                //int correctNumber = 7;
                Random random = new Random();
                int correctNumber = random.Next(1, 11);

                // init guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get user input
                    string input = Console.ReadLine();

                    // Make sure the user input is an actual number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please type in an actual number.");
                        
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again ~ ");
                        
                        /*
                        // Change text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        // Tell user it is the wrong number
                        Console.WriteLine("Wrong number, please try again ~ ");

                        // Reset test color
                        Console.ResetColor();
                        */
                    }
                }

                // Print success message
                PrintColorMessage(ConsoleColor.DarkYellow, "CORRECT!!! Do you want to play again? [Y or N]");

                /*
                // Change text color
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                // Tell user it is the correct number and ask to play again
                Console.WriteLine("CORRECT!!! Do you want to play again? [Y or N]");

                // Reset test color
                Console.ResetColor();
                */

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                while (answer != "Y" && answer != "N") {

                    // Ask user to type in Y or N again
                    PrintColorMessage(ConsoleColor.Red, "Please type in only Y or N");

                    /*
                    // Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Tell user to type in Y or N only
                    Console.WriteLine("Please type in only Y or N");

                    // Reset test color
                    Console.ResetColor();
                    */

                    //Get answer again
                    answer = Console.ReadLine().ToUpper();

                }

                if (answer == "Y") {
                    continue;
                }
                else {

                    // Farewell to the user
                    PrintColorMessage(ConsoleColor.Cyan, "Hope you enjoied it and see you next time!");

                    /*
                    // Change text color
                    Console.ForegroundColor = ConsoleColor.Cyan;

                    // Farewell to the user
                    Console.WriteLine("Hope you enjoied it and see you next time!");

                    // Reset test color
                    Console.ResetColor();
                    */
                    return;
                };
            }                      
        }

        // Get app info and display
        static void GetAppInfo()
        {
            //Set App Vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Vivien Zeng";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset test color
            Console.ResetColor();
        }

        // Ask user name and greet
        static void GreetUser() {
            // Ask user name
            Console.WriteLine("What is your name?");


            // Get user input
            string inputUserName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Hi {0}, let's play a game :)", inputUserName);

            Console.ResetColor(); 
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message) {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user to put in an actual number
            Console.WriteLine(message);

            // Reset test color
            Console.ResetColor();
        }
    }
}
