using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    class RockPaperScissors
    {
        Player player1;
        Player player2;

       

        List<string> gestures = new List <string>();
      
        



        public void SetPlayers()

        {
             Console.WriteLine("how many players are playing?");

            string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    player1 = new Human();  
                    player2 = new Computer();
                }

                else if (userInput == "2")
                {
                player1 = new Human();
                    player2 = new Human();

                }

             

        }

        public void PlayerGestures()
        {
            player1.GetPlayerGesture();
            player2.GetPlayerGesture();
        }

        public void CompareGestures()
        {

        }
    }
}
