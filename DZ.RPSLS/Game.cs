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
        public Player player1;
        public Player player2;
        public int playerOneScore;
        public int playerTwoScore;



        //constructor
        public Game()
        {
            playerOneScore = 0;
            playerTwoScore = 0;
        }

        //member methods (CAN DO)

        public void RunGame()
        {
            Welcome();
            DisplayRules();
            SelectGameMode();
            while (playerOneScore < 3 && playerTwoScore < 3)
            {
                player1.PlayerChoice();
                player2.PlayerChoice();
                CompareGesture();
            }

            DisplayWinner();
            PlayAgain();
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
            Console.WriteLine("Player One Name is: " + playerOneInput);

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
            if (player1.gestureChoice == "Rock" && player2.gestureChoice == "Rock")
            {
                Console.WriteLine("It's a Draw!");
            }
            if (player1.gestureChoice == "Rock" && player2.gestureChoice == "Paper")
            {
                Console.WriteLine("Paper Won!");
                playerTwoScore++;
            }
            if (player1.gestureChoice == "Rock" && player2.gestureChoice == "Scissors")
            {
                Console.WriteLine("Rock Won!");
                playerOneScore++;
            }
            if (player1.gestureChoice == "Rock" && player2.gestureChoice == "Lizard")
            {
                Console.WriteLine("Rock Won!");
                playerOneScore++;
            }
            if (player1.gestureChoice == "Rock" && player2.gestureChoice == "Spock")
            {
                Console.WriteLine("Spock Won!");
                playerTwoScore++;
            }

            // Paper
            if (player1.gestureChoice == "Paper" && player2.gestureChoice == "Paper")
            {
                Console.WriteLine("It's a Draw!");

            }
            if (player1.gestureChoice == "Paper" && player2.gestureChoice == "Rock")
            {
                Console.WriteLine("Paper Won!");
                playerOneScore++;
            }

            if (player1.gestureChoice == "Paper" && player2.gestureChoice == "Scissors")
            {
                Console.WriteLine("Scissors Won!");
                playerTwoScore++;

            }
            if (player1.gestureChoice == "Paper" && player2.gestureChoice == "Lizard")
            {
                Console.WriteLine("Lizard Won!");
                playerTwoScore++;
            }
            if (player1.gestureChoice == "Paper" && player2.gestureChoice == "Spock")
            {
                Console.WriteLine("Paper Won!");
                playerOneScore++;
            }

            //Scissors
            if (player1.gestureChoice == "Scissors" && player2.gestureChoice == "Scissors")
            {
                Console.WriteLine("It's a Draw!");

            }
            if (player1.gestureChoice == "Scissors" && player2.gestureChoice == "Rock")
            {
                Console.WriteLine("Rock Won!");
                playerTwoScore++;
            }

            if (player1.gestureChoice == "Scissors" && player2.gestureChoice == "Paper")
            {
                Console.WriteLine("Scissors Won!");
                playerOneScore++;

            }
            if (player1.gestureChoice == "Scissors" && player2.gestureChoice == "Lizard")
            {
                Console.WriteLine("Scissors Won!");
                playerOneScore++;
            }
            if (player1.gestureChoice == "Scissors" && player2.gestureChoice == "Spock")
            {
                Console.WriteLine("Spock Won!");
                playerTwoScore++;
            }

            // Lizard

            if (player1.gestureChoice == "Lizard" && player2.gestureChoice == "Lizard")
            {
                Console.WriteLine("It's a Draw!");

            }
            if (player1.gestureChoice == "Lizard" && player2.gestureChoice == "Rock")
            {
                Console.WriteLine("Rock Won!");
                playerTwoScore++;
            }

            if (player1.gestureChoice == "Lizard" && player2.gestureChoice == "Paper")
            {
                Console.WriteLine("Lizard Won!");
                playerOneScore++;

            }
            if (player1.gestureChoice == "Lizard" && player2.gestureChoice == "Scissors")
            {
                Console.WriteLine("Scissors Won!");
                playerTwoScore++;
            }
            if (player1.gestureChoice == "Lizard" && player2.gestureChoice == "Spock")
            {
                Console.WriteLine("Lizard Won!");
                playerOneScore++;
            }

            // spock
            if (player1.gestureChoice == "Spock" && player2.gestureChoice == "Spock")
            {
                Console.WriteLine("It's a Draw!");

            }
            if (player1.gestureChoice == "Spock" && player2.gestureChoice == "Rock")
            {
                Console.WriteLine("Spock Won!");
                playerOneScore++;
            }

            if (player1.gestureChoice == "Spock" && player2.gestureChoice == "Paper")
            {
                Console.WriteLine("Paper Won!");
                playerTwoScore++;

            }
            if (player1.gestureChoice == "Spock" && player2.gestureChoice == "Scissors")
            {
                Console.WriteLine("Spock Won!");
                playerOneScore++;
            }
            if (player1.gestureChoice == "Spock" && player2.gestureChoice == "Lizard")
            {
                Console.WriteLine("Lizard Won!");
                playerTwoScore++;
            }




            //// now player 2
            //if (player2.gestureChoice == "Rock" && player1.gestureChoice == "Scissors")
            //{
            //    Console.WriteLine("Rock Wins!");
            //    playerTwoScore++;
            //}
            //if (player2.gestureChoice == "Rock" && player1.gestureChoice == "Lizard")
            //{
            //    Console.WriteLine(" Rock Wins!");
            //    playerTwoScore++;
            //}
            //if (player2.gestureChoice == "Rock" && player1.gestureChoice == "Rock")
            //{
            //    Console.WriteLine(" It's a draw!");
            //}
            //if (player2.gestureChoice == "Paper" && player1.gestureChoice == "Rock")
            //{
            //    Console.WriteLine(" Paper Wins!");
            //    playerTwoScore++;
            //}
            //if (player2.gestureChoice == "Paper" && player1.gestureChoice == "Spock")
            //{
            //    Console.WriteLine(" Paper Wins!");
            //    playerTwoScore++;
            //}
            //if (player2.gestureChoice == "Paper" && player1.gestureChoice == "Paper")
            //{
            //    Console.WriteLine(" It's a draw!");
            //}
            //if (player1.gestureChoice == "Scissors" && player1.gestureChoice == "Paper")
            //{
            //    Console.WriteLine(" Scissors Wins!");
            //    playerTwoScore++;
            //}
            //if (player2.gestureChoice == "Scissors" && player1.gestureChoice == "Lizard")
            //{
            //    Console.WriteLine(" Scissors Wins!");
            //    playerTwoScore++;
            //}
            //if (player2.gestureChoice == "Scissors" && player1.gestureChoice == "Scissors")
            //{
            //    Console.WriteLine(" It's a draw!");

            //}

            //if (player2.gestureChoice == "Lizard" && player1.gestureChoice == "Spock")
            //{
            //    Console.WriteLine(" Lizard Wins!");
            //    playerTwoScore++;
            //}
            //if (player2.gestureChoice == "Lizard" && player1.gestureChoice == "Paper")
            //{
            //    Console.WriteLine(" Lizard Wins!");
            //    playerTwoScore++;
            //}
            //if (player2.gestureChoice == "Lizard" && player1.gestureChoice == "Lizard")
            //{
            //    Console.WriteLine(" It's a draw!");
            //}
            //if (player2.gestureChoice == "Spock" && player1.gestureChoice == "Scissors")
            //{
            //    Console.WriteLine(" Spock Wins!");
            //    playerTwoScore++;
            //}

            //if (player2.gestureChoice == "Spock" && player1.gestureChoice == "Rock")
            //{
            //    Console.WriteLine(" Spock Wins!");
            //    player2.score++;
            //}
            //if (player2.gestureChoice == "Spock" && player1.gestureChoice == "Spock")
            //{
            //    Console.WriteLine(" It's a draw!");
            //}



        }


        public void DisplayWinner()
        {
            if (player1.score <= 3)
            {
                Console.WriteLine("Player One Wins!");
            }
            else if (player2.score <= 3)
            {
                Console.WriteLine("Player Two Wins!");
            }
            else
            {
                Console.WriteLine("Winner has not been determined yet");
            }

        }
        public void PlayAgain()
        {
            Console.WriteLine("Would you like to play another game? Press 1 to Run Again. Press 2 to End Game");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == 1)
            {
                RunGame();
            }




        }

    }  


    }




