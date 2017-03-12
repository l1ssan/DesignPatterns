using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class Warrior:Character
    {
        public Warrior(IWeapon wp) : base(wp)
        {
        }

        public override void GetExp()
        {
            Console.WriteLine("You have got 252 exp. Point");
        }
    }
}
