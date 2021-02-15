using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ.RPSLS
{
    public class Game
    {
        //member variables (HAS A)
        Player player1;
        Player player2;
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
            SelectGameMode();
            ShowOptions();

            while (player1.score < 3 && player2.score < 3)
            {
                Human gesture = new Human();
                gesture.PlayerChoice();

                ComputerAI aiGesture = new ComputerAI();
                aiGesture.PlayerChoice();

            }
        }

        public void Welcome()
        {
            Console.WriteLine("Welcome to RPSLS!");
        }

        public void DisplayRules()
        {
            Console.WriteLine("You will choose Rock, Paper, Scissors, Lizard, or Spock. " +
                "First to 3 Points will be declared the winner. Each rounds is worth one point.");
            Console.WriteLine("Rules: ");
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
            Console.WriteLine("Press 1 to start Single Player or Press 2 to start Multiplayer");
            string userInputGameMode = Console.ReadLine();

            if (userInputGameMode == "1")
            {
                player1 = new Human();
                player1.name = EnterPlayerOneName();
                player2 = new ComputerAI();
            }
            else
            {
                player1 = new Human();
                player2 = new Human();
                player1.name = EnterPlayerOneName();
                player2.name = EnterPlayerTwoName();
            }
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

        public string ShowOptions()
        {
            Console.WriteLine("Here are all the gestures you can use");
            Console.WriteLine("Rock");
            Console.WriteLine("Paper");
            Console.WriteLine("Scissors");
            Console.WriteLine("Lizard");
            Console.WriteLine("Spock");
            return Console.ReadLine();
            // use for loop or maybe switch case??           
        }

        public void CompareGesture()
        {
            if (player1.gestureChoice == "0" && player2.gestureChoice == "2")
            {
                Console.WriteLine("Rock Wins!");
                player1.score++;
            }
            if (player1.gestureChoice == "0" && player2.gestureChoice == "3")
            {
                Console.WriteLine(" Rock Wins!");
                player1.score++;
            }
            if (player1.gestureChoice == "0" && player2.gestureChoice == "0")
            {
                Console.WriteLine(" It's a draw!");
            }
            if (player1.gestureChoice == "1" && player2.gestureChoice == "0")
            {
                Console.WriteLine(" Paper Wins!");
                player1.score++;
            }
            if (player1.gestureChoice == "1" && player2.gestureChoice == "4")
            {
                Console.WriteLine(" Paper Wins!");
                player1.score++;
            }
            if (player1.gestureChoice == "1" && player2.gestureChoice == "1")
            {
                Console.WriteLine(" It's a draw!");
            }
            if (player1.gestureChoice == "2" && player2.gestureChoice == "1")
            {
                Console.WriteLine(" Scissors Wins!");
                player1.score++;
            }
            if (player1.gestureChoice == "2" && player2.gestureChoice == "3")
            {
                Console.WriteLine(" Scissors Wins!");
                player1.score++;
            }
            if (player1.gestureChoice == "2" && player2.gestureChoice == "2")
            {
                Console.WriteLine(" It's a draw!");
               
            }

            if (player1.gestureChoice == "3" && player2.gestureChoice == "4")
            {
                Console.WriteLine(" Lizard Wins!");
                player1.score++;
            }
            if (player1.gestureChoice == "3" && player2.gestureChoice == "1")
            {
                Console.WriteLine(" Lizard Wins!");
                player1.score++;
            }
            if (player1.gestureChoice == "3" && player2.gestureChoice == "3")
            {
                Console.WriteLine(" It's a draw!");
            }
            if (player1.gestureChoice == "4" && player2.gestureChoice == "2")
            {
                Console.WriteLine(" Spock Wins!");
                player1.score++;
            }

            if (player1.gestureChoice == "4" && player2.gestureChoice == "0")
            {
                Console.WriteLine(" Spock Wins!");
                player1.score++;
            }
            if (player1.gestureChoice == "4" && player2.gestureChoice == "4")
            {
                Console.WriteLine(" It's a draw!");
            }

            // now player 2
            if (player2.gestureChoice == "0" && player1.gestureChoice == "2")
            {
                Console.WriteLine("Rock Wins!");
                player2.score++;
            }
            if (player2.gestureChoice == "0" && player1.gestureChoice == "3")
            {
                Console.WriteLine(" Rock Wins!");
                player2.score++;
            }
            if (player2.gestureChoice == "0" && player1.gestureChoice == "0")
            {
                Console.WriteLine(" It's a draw!");
            }
            if (player2.gestureChoice == "1" && player1.gestureChoice == "0")
            {
                Console.WriteLine(" Paper Wins!");
                player2.score++;
            }
            if (player2.gestureChoice == "1" && player1.gestureChoice == "4")
            {
                Console.WriteLine(" Paper Wins!");
                player2.score++;
            }
            if (player2.gestureChoice == "1" && player1.gestureChoice == "1")
            {
                Console.WriteLine(" It's a draw!");
            }
            if (player1.gestureChoice == "2" && player1.gestureChoice == "1")
            {
                Console.WriteLine(" Scissors Wins!");
                player2.score++;
            }
            if (player2.gestureChoice == "2" && player1.gestureChoice == "3")
            {
                Console.WriteLine(" Scissors Wins!");
                player2.score++;
            }
            if (player2.gestureChoice == "2" && player1.gestureChoice == "2")
            {
                Console.WriteLine(" It's a draw!");

            }

            if (player2.gestureChoice == "3" && player1.gestureChoice == "4")
            {
                Console.WriteLine(" Lizard Wins!");
                player2.score++;
            }
            if (player2.gestureChoice == "3" && player1.gestureChoice == "1")
            {
                Console.WriteLine(" Lizard Wins!");
                player2.score++;
            }
            if (player2.gestureChoice == "3" && player1.gestureChoice == "3")
            {
                Console.WriteLine(" It's a draw!");
            }
            if (player2.gestureChoice == "4" && player1.gestureChoice == "2")
            {
                Console.WriteLine(" Spock Wins!");
                player2.score++;
            }

            if (player2.gestureChoice == "4" && player1.gestureChoice == "0")
            {
                Console.WriteLine(" Spock Wins!");
                player2.score++;
            }
            if (player2.gestureChoice == "4" && player1.gestureChoice == "4")
            {
                Console.WriteLine(" It's a draw!");
            }



        }

        public void CurrentScore()
        {
            Console.WriteLine("{0}, {1}");
        }
        
        public void DisplayWinner()
        {
            if (player1.score == 3)
            {
                Console.WriteLine("Player One Wins!");
            }
            else if (player2.score == 3)
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
