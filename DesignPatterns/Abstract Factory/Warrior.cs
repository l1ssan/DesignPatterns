using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Abstract_Factory
{
    public class WarriorFactory:PlayerFactory
    {

        public override Weapon CreateWeapon()
        {
            return new Axe();
        }

        public override Movement CreateMovement()
        {
            return new Run();
        }
    }
}
