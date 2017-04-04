using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class LightningWeapon : WeaponDecorator
    {
        public LightningWeapon(Weapon weapon) : base(weapon.Name + " of Lightning", weapon)
        {
        }

        public override int GetCost()
        {
            return Weapon.GetCost() + 30;
        }
    }
}
