using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ.RPSLS
{
    class Player
    {
        //member variables (HAS A)
        public string name;
        public int score;
        public int choice;

        //constructor
        public Player(string name, int score, int choice)
        {
            this.name = name;
            score = 0;
            this.choice = choice;
        }

        //member methods (CAN DO)
    }
}
