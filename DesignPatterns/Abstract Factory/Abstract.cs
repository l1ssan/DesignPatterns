using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Abstract_Factory
{
    public abstract class Weapon
    {
        public abstract int Hit();
    }
    public abstract class Movement
    {
        public abstract int Move();
    }
}
