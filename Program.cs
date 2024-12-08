// Three possible outcomes
// Rock, Paper, Scissor
// A button to give the user 3 choices, either between Rock, Papper, Scissors

using System;

public class Program
{
    enum Choice
    {
        Rock, Paper, Scissors // Three possible answers
    }

    static void Main(string[] args)
    {
        bool keepPlaying = true; // loop to ask the user if he wants to keep playing or not
        while (keepPlaying)
        {
            Console.WriteLine("Welcome to Rock Game!");

            // Print out the options for the player
            Console.WriteLine("Choose from the following options:");
            Console.WriteLine("1.Rock");
            Console.WriteLine("2.Paper");
            Console.WriteLine("3. Scissors");


            // Get the player's choice 
            string playerChoice = GetPlayerchoice();
            Console.WriteLine("You choose: " + playerChoice);


            // Generate the computer's choice
            string computerChoice = GenerateComputerChoice();
            Console.WriteLine("Computer chose " + computerChoice);

            // Compare choices and tell the result
            string result = CompareChoices(playerChoice, computerChoice);


            // Display choices 
            Console.WriteLine(result);

            // Ask the user if they want to play again
            Console.WriteLine("Do you want to play again? (yes/no)");
            string response = Console.ReadLine();
            if (response.Equals("yes"))

            {
                keepPlaying = true;
            }
            else if (response.Equals("no"))
            {
                keepPlaying = false;
                Console.WriteLine("Thank you for playing!");
            }
        }

    }

// This method get the Computer's choice
    static string GenerateComputerChoice()
    {
        string[] computerChoice = { "Rock", "Paper", "Scissors" };
        Random rand = new Random(); // Create a random object called rand could be called anything but mostly rand
        int randomNumber = rand.Next(0, 3); // Generatea a random number between 0 and 2 wihout 3 
        return computerChoice[randomNumber]; // Return the computers choice as a string
    }


    // This method gets the Player's choice
    static string GetPlayerchoice()
    {
        Console.WriteLine("Enter your choice (Rock, Paper, or Scissors): ");
        string playerChoice = Console.ReadLine();
        return playerChoice;
    }

    static string CompareChoices(string playerChoice, string computerChoice)
    {
        if (playerChoice == computerChoice)
        {
            return "It's a tie!";
        }
        else if ((playerChoice == "Rock" && computerChoice == "Scissors") ||
                 (playerChoice == "Scissors" && computerChoice == "Paper") ||
                 (playerChoice == "Paper" && computerChoice == "Rock"))
        {
            return "You win"; // Player's choice beats the computer's choice
        }
        else
        {
            return "Computer wins!"; // Otherwise, computer wins
        }
    }
}

