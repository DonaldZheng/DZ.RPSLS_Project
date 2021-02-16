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
            random = new Random();
            this.name = "AI";
            score = 0;
        }



        //member methods (CAN DO)
        public override void PlayerChoice()
        {


            int randomChoice = random.Next(gestures.Count);
            Console.WriteLine("AI has played" + gestures[randomChoice]);
            gestureChoice = gestures[randomChoice];

           

            //string aiChoice = randomChoice.ToString();

            //return gestures[randomChoice];

            //    int aiChoice;
            //    Random random = new Random();
            //    aiChoice = random.Next();
            //    switch (aiChoice)


        }
    }
}
