using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class Machete : IColdWeapon
    {
        private int dmgRate = 5;
        public void DealDamage(int dmg)
        {
            Console.WriteLine("Machete deals {0} dmg", dmg * dmgRate);
        }
    }
}
