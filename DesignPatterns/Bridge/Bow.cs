using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class Bow:IWeapon
    {
        public void Get()
        {
            Console.WriteLine("Get the Bow from Inventory");
        }

        public void Hit()
        {
            Console.WriteLine("Get the Arrow");
            Console.WriteLine("Stretch the String");
            Console.WriteLine("Shut it down.");

        }
    }
}
