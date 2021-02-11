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


        //constructor
        public ComputerAI(string name, int score, string gestureChoice)
        {
            Player AiOne = new Player("AiOne", 1, "Rock");
            score = 0;
        }

        //member methods (CAN DO)
    }
}
