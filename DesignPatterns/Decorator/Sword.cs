using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class Sword : Weapon
    {
        public Sword(string n) : base("Iron Sword")
        {
        }

        public override int GetCost()
        {
            return 50;
        }
    }
}
