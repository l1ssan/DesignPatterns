using System;


namespace DesignPatterns.State
{
    public class GoodConditionHouseState : IBuildingState
    {
        public void Build(House house)
        {
            Console.WriteLine("The house is already built");
        }

        public void Damage(House house)
        {
            Console.WriteLine("You damaged the house. Now the house is damaged and needs repair");
            house.State = new DamagedHouseState();
        }

        public void Destroy(House house)
        {
            Console.WriteLine("You destroyed the house");
            house.State = new DestroyedHouseState();
        }

        public void Repair(House house)
        {
            Console.WriteLine("The house is in good condition and does not need repair");
        }
    }
}
