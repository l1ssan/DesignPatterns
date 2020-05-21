using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class HouseUnderConstructionState : IBuildingState
    {
        public void Build(House house)
        {
            Console.WriteLine("You built a house");
            house.State = new GoodConditionHouseState();
        }

        public void Damage(House house)
        {
            Console.WriteLine("You destroyed the house under construction");
            house.State = new DestroyedHouseState();
        }

        public void Destroy(House house)
        {
            Console.WriteLine("You destroyed the house");
            house.State = new DestroyedHouseState();
        }

        public void Repair(House house)
        {
            Console.WriteLine("You cannot repair a house under construction");
        }
    }
}
