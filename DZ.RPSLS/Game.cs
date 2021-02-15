using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ.RPSLS
{
    class Game
    {
        //member variables (HAS A)
        Player playerOneScore;
        Player playerTwoScore;

        //constructor
        public Game()
        {

        }

        //member methods (CAN DO)

        public void RunGame()
        {
            Welcome();
            DisplayRules();
        }

        public void Welcome()
        {
            Console.WriteLine("Welcome to RPSLS!");
        }

        public void DisplayRules()
        {
            Console.WriteLine("You will choose Rock, Paper, Scissors, Lizard, or Spock. " +
                "First to 3 Points will be declared the winner. Each rounds is worth one point");
            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
        }

        public void SelectGameMode()
        {
            Console.WriteLine("Press 1 to start Single Player or Press 2 to start Multiplayer" );
        }

        public string EnterPlayerOneName()
        {
            Console.WriteLine("Player One: Enter Your Name");
            string playerOneInput = Console.ReadLine();
            Console.WriteLine("Player One Name is:" + playerOneInput);

            return playerOneInput;
        }

        public string EnterPlayerTwoName()
        {
            Console.WriteLine("Player Two: Enter Your Name");
            string playerTwoInput = Console.ReadLine();
            Console.WriteLine("Player Two Name is:" + playerTwoInput);

            return playerTwoInput;

        }

        public void DisplayGesture()
        {
            Console.WriteLine("Pick the Gesture you would like to use:");
            Console.WriteLine("1: Rock");
            Console.WriteLine("2: Paper");
            Console.WriteLine("3: Scissors");
            Console.WriteLine("4: Lizard");
            Console.WriteLine("5: Spock");


        }

        
        public void DisplayWinner()
        {
            if (playerOneScore.score == 3)
            {
                Console.WriteLine("Player One Wins!");
            }
            else if (playerOneScore.score == 3)
            {
                Console.WriteLine("Player Two Wins!");            
            }
            else
            {
                Console.WriteLine("Winner has not been determined yet");
            }
        }



    }
}
