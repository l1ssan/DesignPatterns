using System;


namespace DesignPatterns.Prototype
{
    public class FlightUnit : IUnit
    {
        int HP { get; set; }
        int SP { get; set; }
        string UnitName { get; set; }

        Weapon Weapon { get; set; }

        public int MaxHeight { get; set; }

        public FlightUnit(int hp, int sp, string unitName, Weapon weapon, int maxHeight)
        {
            HP = hp;
            SP = sp;
            UnitName = unitName;
            Weapon = weapon;
            MaxHeight = maxHeight;
        }
        public IUnit Clone()
        {
            return new FlightUnit(HP, SP, UnitName, Weapon, MaxHeight);
        }

        public void GetInfo()
        {
            Console.WriteLine("Earth Unit with HP {0} SP {1} UnitName {2} MaxHeight {3}", HP, SP, UnitName, MaxHeight);
            Console.WriteLine("Weapon Name {0} Damage {1} Range {2} ", Weapon.Name, Weapon.Damage, Weapon.Range);
        }
    }
}
