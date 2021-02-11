using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ.RPSLS
{
    class Battlefield
    {   //Scissors cuts paper 
        //Rock crushes Scissors  
        //Scissors cuts Paper
        //Paper covers Rock
        //Rock crushes Lizard
        //Lizard poisons Spock
        //Spock smashes Scissors
        //Scissors decapitates Lizard
        //Lizard eats Paper
        //Paper disproves Spock
        //Spock vaporizes Rock


        //member variables (HAS A)

        //constructor
        public Battlefield()
        {

        }

        //member methods (CAN DO)
        public void Welcome()
        {
            Console.WriteLine("Welcome to RPSLS!");
        }

        public void DisplayRules()
        {
            Console.WriteLine("You will choose Rock, Paper, Scissors, Lizard, or Spock. " +
                "First to 3 Points will be declared the winner. Each rounds is worth one point");
        }





    }
}
