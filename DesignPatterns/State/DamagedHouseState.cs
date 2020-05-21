using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class DamagedHouseState : IBuildingState
    {
        public void Build(House house)
        {
            Console.WriteLine("You cannot build a damaged house");
        }

        public void Damage(House house)
        {
            Console.WriteLine("You destroyed the house");

        }

        public void Destroy(House house)
        {
            Console.WriteLine("You destroyed the house");
            house.State = new DestroyedHouseState();
        }

        public void Repair(House house)
        {
            Console.WriteLine("You have successfully repaired the house");
            house.State = new GoodConditionHouseState();
        }
    }
}
