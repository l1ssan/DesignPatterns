using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class DestroyedHouseState : IBuildingState
    {
        public void Build(House house)
        {
            Console.WriteLine("You built a new house");
            house.State = new GoodConditionHouseState();
        }

        public void Damage(House house)
        {
            Console.WriteLine("There is nothing to damage");
        }

        public void Destroy(House house)
        {
            Console.WriteLine("There is nothing to destroy");
        }

        public void Repair(House house)
        {
            Console.WriteLine("There is nothing to repair");
        }
    }
}
