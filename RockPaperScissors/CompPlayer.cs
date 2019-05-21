using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class CompPlayer:Player
    {
        //function to generate random choice for computer
        public string GenerateChoice()
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


    }

}
