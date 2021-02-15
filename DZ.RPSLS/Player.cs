using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ.RPSLS
{
    public abstract class Player
    {
        //member variables (HAS A)
        public string name;
        public int score;
        public string gestureChoice;
        public List<string> gestures;

        //constructor
        public Player()
        {
            gestures = new List<string>();
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissor");
            gestures.Add("Lizard");
            gestures.Add("Spock");

            //string rock = "rock";
            //string paper = "Paper";
            //string scissor = "Scissor";
            //string lizard = "Lizard";
            //string spock = "Spock";
        }

        //member methods (CAN DO)
        public virtual void PlayerChoice()
        {
        
        }
        
    }
}
