using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1_AN
{
    public class Player : Character
    {
        public Player(string name, int health) : base(name,500)
        {
        }

        public override void ShowMessage()
        {
            Console.WriteLine("Adventurer, you shall find the hidden treasure of the Crownguard Family");

        }
    }
}
