using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class FireDecorator : WeaponDecorator
    {
        public FireDecorator(Weapon weapon) : base(weapon.Name+" of Flame", weapon)
        {

        }

        public override int GetCost()
        {
            return Weapon.GetCost() + 45;
        }
    }
}
