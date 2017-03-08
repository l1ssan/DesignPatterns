using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class Player
    {
        private int Str=3;
        private int Dex=4;

        public void Atack(IWeapon weapon)
        {
            weapon.DealDamage(Str+Dex);
        }
    }
}
