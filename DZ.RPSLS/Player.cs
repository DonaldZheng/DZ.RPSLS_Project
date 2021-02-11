using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ.RPSLS
{
    public class Player
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
            
        }

        //member methods (CAN DO)
        public void playerChoice()
        {
        
        }
    }
}
