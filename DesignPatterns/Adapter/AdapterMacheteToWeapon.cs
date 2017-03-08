using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class AdapterMacheteToWeapon : IWeapon
    {
        private Machete machete;
        public AdapterMacheteToWeapon(Machete w)
        {
            machete = w;
        }


        public void DealDamage(int dmg)
        {
           machete.DealDamage(dmg);
        }
    }
}

