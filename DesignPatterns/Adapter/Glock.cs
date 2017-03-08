using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class Glock : IWeapon
    {
        private int dmgRate = 10;
        public void DealDamage(int dmg)
        {
            Console.WriteLine("Glock deals {0} dmg", dmg*dmgRate);
        }
    }
}
