using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public class EarthUnit : IUnit
    {
        int HP { get; set; }
        int SP { get; set; }
        string UnitName { get; set; }

        Weapon Weapon { get; set; }

        public int MaxDistance { get; set; }

        public EarthUnit(int hp, int sp, string unitName, Weapon weapon, int maxDistance)
        {
            HP = hp;
            SP = sp;
            UnitName = unitName;
            Weapon = weapon;
            MaxDistance = maxDistance;
        }

        public IUnit Clone()
        {
            return new EarthUnit(HP, SP, UnitName, Weapon, MaxDistance);
        }

        public void GetInfo()
        {
            Console.WriteLine("Earth Unit with HP {0} SP {1} UnitName {2} MaxDistance {3}", HP, SP, UnitName, MaxDistance);
            Console.WriteLine("Weapon Name {0} Damage {1} Range {2} ", Weapon.Name, Weapon.Damage, Weapon.Range);
        }
    }
}
