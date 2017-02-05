using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Abstract_Factory
{
   public abstract class PlayerFactory
   {
       public abstract Weapon CreateWeapon();
       public abstract Movement CreateMovement();
   }

}
