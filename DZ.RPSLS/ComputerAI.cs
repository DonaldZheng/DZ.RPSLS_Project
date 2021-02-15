using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ.RPSLS
{
    public class ComputerAI : Player 
    {
        //member variables (HAS A)
        Random random; //random number generator 

        //constructor
        public ComputerAI() //string name, int score, string gestureChoice
        {
            Random random = new Random();
            //this.name = "AI";
            score = 0;
        }

        

        //member methods (CAN DO)
        public void RandomNumberGenerator()
        {
            //for (int i = 0; i < gestures.Count; i++)
            //{
            //    Console.WriteLine("Enter " + i + "for " + gestures[i]);
            //}

        }
        public override void PlayerChoice()
        {

        }
    }
}
