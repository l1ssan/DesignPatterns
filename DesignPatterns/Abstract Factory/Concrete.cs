using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Abstract_Factory
{
    public class Bow : Weapon
    {
        public override int Hit()
        {
            Console.WriteLine("Damage dealt: ");
            return 10;
        }
    }

    public class Axe : Weapon
    {
        public override int Hit()
        {
            Console.WriteLine("Damage dealt: ");
            return 15;
        }
    }



    public class Fly : Movement
    {
        public override int Move()
        {
            Console.WriteLine("Fly range: ");
            return 20;
        }
    }
    public class Run : Movement
    {
        public override int Move()
        {
            Console.WriteLine("Move range: ");
            return 10;
        }
    }

}
