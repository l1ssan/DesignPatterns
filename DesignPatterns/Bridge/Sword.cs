using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class Sword:IWeapon
    {
        public void Get()
        {
            Console.WriteLine("Get the Sword from Inventory");
        }

        public void Hit()
        {
            Console.WriteLine("Get the sword out of the scabbard");
            Console.WriteLine("Hit the Mob");

        }
    }

}
