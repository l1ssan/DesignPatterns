using System;
using DesignPatterns.Abstract_Factory;
using DesignPatterns.Adapter;
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
