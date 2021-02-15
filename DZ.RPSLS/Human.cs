using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ.RPSLS
{
    public class Human: Player
    {
        //member variables (HAS A)

        //constructor
        public Human()
        {
            //this.name = "Donald";
            score = 0;
            //this.gestureChoice = gestureChoice;
        }



        //member methods (CAN DO)
        public override void PlayerChoice()
        {
            Console.WriteLine("Pick the choice you would like to use:");
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine("Press " + i + " for " + gestures[i]);
            }
            string userInput = Console.ReadLine();
            int chosenGesture = Int32.Parse(userInput);
        }

    }
}
