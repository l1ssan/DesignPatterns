using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
   public abstract class WeaponDecorator: Weapon
   {
       protected Weapon Weapon;

       protected WeaponDecorator(string n, Weapon weapon) : base(n)
       {
           this.Weapon = weapon;
       }


    }
}
