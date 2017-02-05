using System;
using DesignPatterns.Abstract_Factory;

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


            Console.ReadLine();
        }
    }
}
