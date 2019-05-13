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

            Console.WriteLine("Enter r for Rock, p for Paper and s for Scissors");


            while (playerScore < 5 && compScore < 5)
            {
                
                string userInput = Console.ReadLine().ToLower();

                string compChoice = compPlayer.GenerateChoice();

                Console.WriteLine($"The computer has {compChoice}");

                Console.Write(CompareAnswers(userInput, compChoice) );

                Console.WriteLine($": Score --> Player: {playerScore} Computer: {compScore}");

                Console.WriteLine("Enter r for Rock, p for Paper and s for Scissors");

            }

            if (playerScore == 5)
            {
                Console.WriteLine("Player is the winner!");
            } else
            {
                Console.WriteLine("Computer is the winner!");

            }

        }

        public string GenerateCompChoice()
        {
            string compChoice = "";
            Random rnd = new Random();
            int compInput = rnd.Next(1, 4);

            switch (compInput)
            {
                case 1:
                    compChoice = "r";
                    break;
                case 2:
                    compChoice = "p";
                    break;
                case 3:
                    compChoice = "s";
                    break;
                default:
                    break;
            }


            return compChoice;
        }

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
