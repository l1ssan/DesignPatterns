using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
   public  class Archer : Character
    {
       public Archer(IWeapon wp) : base(wp)
       {

       }

       public override void GetExp()
       {
          Console.WriteLine("You have got 238 exp. point");
       }
    }
}
