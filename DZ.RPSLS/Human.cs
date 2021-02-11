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
        public Human(string name, int score, string gestureChoice)
        {
            this.name = "Donald";
            score = 0;
            this.gestureChoice = gestureChoice;
        }

        //member methods (CAN DO)
    }
}
