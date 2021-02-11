using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ.RPSLS
{
    class Battlefield
    {   
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





    }
}
