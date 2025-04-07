using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1_AN
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int Health;
        public Character(string name, int health)
        {
            Name = name;
            Health = health;
        }
        public abstract void ShowMessage();
    }

}
