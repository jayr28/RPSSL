using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    public abstract class Player
    {
        public string name;
        public int gesture;
        public int score;

        public abstract void GetPlayerGesture();

        public gestures()
        {
            Rock = "1";
            Paper = "2";
            Scissors = "3";
            Spock = "4";
            Lizards "5";
                
        }

        public abstract void SetName();

    }
}
