using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    class Human : Player
    {
        public override void GetPlayerGesture()
        {
            Console.WriteLine("press 1 for Rock");
            gesture = int.Parse(Console.ReadLine());
        }

        public override void SetName()
        {
            Console.WriteLine("what is your name?");
            name = Console.ReadLine();
        }
    }
}
