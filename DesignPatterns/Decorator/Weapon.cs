using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public abstract class Weapon
    {
        protected Weapon(string n)
        {
            this.Name = n;
        }

        public string Name { get; protected set; }

        public abstract int GetCost();

    }
}
