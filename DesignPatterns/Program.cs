using System;
using System.ComponentModel;
using DesignPatterns.Abstract_Factory;
using DesignPatterns.Adapter;
using DesignPatterns.Bridge;
using DesignPatterns.Builder;
using DesignPatterns.Composite;
using Player = DesignPatterns.Abstract_Factory.Player;
using Sword = DesignPatterns.Bridge.Sword;

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

           BuilderExample();

            //check composite 
            var objectsCategory = new Category("Objects");
            var weaponCategory = new Category("Weapons");
            var armorCategory = new Category("Armors");

            var item = new MenuItem("Battle Axe");
            var item1 = new MenuItem("Long Sword");

            var ac = new MenuItem("Plate");
            var ac1 = new MenuItem("Tights");

            weaponCategory.Add(item);
            weaponCategory.Add(item1);
            armorCategory.Add(ac);
            armorCategory.Add(ac1);
            objectsCategory.Add(weaponCategory);
            objectsCategory.Add(armorCategory);

            objectsCategory.Print();

            weaponCategory.Print();

            armorCategory.Print();


            //check decorator

            Decorator.Weapon mysword = new Decorator.Sword("Player1 Sword");
            Console.WriteLine($"{mysword.Name} cost {mysword.GetCost()} p.");
            Console.WriteLine("Update my sword");
       
            mysword = new Decorator.FireDecorator(mysword);
            Console.WriteLine($"{mysword.Name} cost {mysword.GetCost()} p.");


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

        public static void BuilderExample()
        {
            Blacksmith blacksmith = new Blacksmith();
            SwordBuilder builder = new GoodIronSwordBuilder();
            // выпекаем
            Builder.Sword IronSword = blacksmith.ForgeSword(builder);
            Console.WriteLine(IronSword.ToString());
            // оздаем билдер для пшеничного хлеба
            builder = new AdamantitSwordBuilder();
            Builder.Sword AdamantitSword =  blacksmith.ForgeSword(builder);
            Console.WriteLine(AdamantitSword.ToString());
        }
    }
}
