using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Abstract_Factory
{
    public class ArcherFactory : PlayerFactory
    {
        public override Weapon CreateWeapon()
        {
            return new Bow();
        }

        public override Movement CreateMovement()
        {
            return new Fly();
        }
    }
}
