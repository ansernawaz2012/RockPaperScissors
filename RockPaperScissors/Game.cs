using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        public int compScore = 0;
        public int playerScore = 0;
        public Game()
        {


            playGame();
        }

        public void playGame()
        {
            Player player = new Player();
            CompPlayer compPlayer = new CompPlayer();
            string userInput = "";
            Console.WriteLine("Enter r for Rock, p for Paper and s for Scissors");

            //Loop until one player reaches a score of 5
            while (playerScore < 5 && compScore < 5)
            {
                //Loop to validate user input
                Boolean validInput = false;
                while (!validInput)
                {

                    userInput = Console.ReadLine().ToLower();
                    if (userInput == "r" || userInput == "p" || userInput == "s")
                    {
                        validInput = true;
                    }
                    
                    else
                    {
                        validInput = false;
                        Console.WriteLine("Invalid input! Please enter 'r', 'p' or 's'.");
                    }
                }

                string compChoice = compPlayer.GenerateChoice();

                Console.WriteLine($"The computer has {compChoice}");

                Console.Write(CompareAnswers(userInput, compChoice) );

                Console.WriteLine($": Score --> Player: {playerScore} Computer: {compScore}");

                Console.WriteLine("Enter r for Rock, p for Paper and s for Scissors");

            }

            //End game when either payer reaches 5
            if (playerScore == 5)
            {
                Console.WriteLine("Player is the winner!");
            } else
            {
                Console.WriteLine("Computer is the winner!");

            }

        }

        //Compare input for each round and update score accordingly

        public string CompareAnswers(string userInput, string compChoice)
        {
            string message = "";

            if (userInput == compChoice)
            {
                message = "draw";
            }
            else if (userInput == "r" && compChoice == "s")
            {
                message = "Player Wins!";
                playerScore++;
            }
            else if (userInput == "p" && compChoice == "r")
            {
                message = "Player Wins!";
                playerScore++;
            }
            else if (userInput == "s" && compChoice == "p")
            {
                message = "Player Wins!";
                playerScore++;
            }
            else
            {
                message = "Computer Wins!";
                compScore++;
            }


            return message;
        }
    }
}
