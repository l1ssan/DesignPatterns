using System;
using DesignPatterns.Abstract_Factory;
using DesignPatterns.Adapter;
using DesignPatterns.Bridge;
using Player = DesignPatterns.Abstract_Factory.Player;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var warPlayer = new Player(new WarriorFactory());
            var archPlayer = new Player(new ArcherFactory());

            warPlayer.Hit();
            warPlayer.Run();

            archPlayer.Hit();
            archPlayer.Run();

            //check adapter
            AdapterSample();
            //check bridge 
           
            Character myCharacter = new Warrior(new Sword());
            myCharacter.KillMobs();
            myCharacter.GetExp();

            myCharacter.Weapon = new Bridge.Bow();

            //need to kill flying mobs
            myCharacter.KillMobs();
            myCharacter.GetExp();

            Console.ReadLine();


        }

        public static void AdapterSample()
        {
            var player = new Adapter.Player();
            
            //standart way
            player.Atack(new Glock());

            //adopted class
            var adoptedWeapon = new AdapterMacheteToWeapon(new Machete());

            player.Atack(adoptedWeapon);

        }
    }
}
