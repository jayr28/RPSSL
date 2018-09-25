using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    class Computer : Player
    {
        public override void GetPlayerGesture()
        {
            Random random = new Random();
            gesture = random.Next(1, 5);
        }

        public override void SetName()
        {
            name = "Computer";
        }
    }
}
