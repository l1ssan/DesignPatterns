using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public abstract class Character
    {
        protected IWeapon weapon;
        public IWeapon Weapon
        {
            set { weapon = value; }
        }
        public Character(IWeapon wp)
        {
            weapon = wp;
        }
        public virtual void KillMobs()
        {
            weapon.Get();
            weapon.Hit();
        }
        public abstract void GetExp();
    }
}
