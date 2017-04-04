using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
   public class MagicSword:Weapon
    {
       public MagicSword(string n) : base("Magic Sword of Life")
       {
       }

       public override int GetCost()
       {
           return 100;
       }

    }
}
