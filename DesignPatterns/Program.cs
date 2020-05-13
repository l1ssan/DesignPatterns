using System;
using DesignPatterns.Abstract_Factory;
using DesignPatterns.Adapter;
using DesignPatterns.Bridge;
using DesignPatterns.Builder;
using DesignPatterns.Composite;
using DesignPatterns.Facade;
using DesignPatterns.Factory_Method;
using DesignPatterns.Flyweight;
using DesignPatterns.Interpreter;
using DesignPatterns.Iterator;
using DesignPatterns.Mediator;
using DesignPatterns.Memento;
using DesignPatterns.Observer;
using DesignPatterns.Prototype;
using DesignPatterns.Proxy;
using Character = DesignPatterns.Bridge.Character;
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

            //check facade

            MagicBook mb = new MagicBook();
            MagicTable mt = new MagicTable();
            ReagentsCreator rc = new ReagentsCreator();

            MagicRitualFacade mr = new MagicRitualFacade(mb, mt, rc);

            Mage xatab = new Mage();
            xatab.SummonImp(mr);


            //abstact method factory

            Developer dev = new WoodDeveloper("poor civilization");
            var castle = dev.Create();

            dev = new StoneDeveloper("grate civilization");
            var castle2 = dev.Create();



            //check flyweight

            double xstart = 0;
            double ystart = 0;

            var houseFactory = new ConstructionFactory();


            for (int i = 0; i < 5; i++)
            {
                var wmConstruction = houseFactory.GetConstruction("WarMachineFactory");
                wmConstruction?.Build(xstart, ystart);
                ystart += 105;

                var brickHouse = houseFactory.GetConstruction("Warehouse");
                brickHouse?.Build(xstart, ystart);
                ystart += 205;
                xstart += 310;
            }



            //check interpret
            var context = new Context();

            double x = 3;
            double y = 4;
            double z = 5;
            double d = 4;
            double m = 10;

            // add var 
            context.SetVariable("x", x);
            context.SetVariable("y", y);
            context.SetVariable("z", z);
            context.SetVariable("d", d);
            context.SetVariable("m", m);

            // exp m*x + y - z/d 
            IExpression expression = new SubtractExpression(

                new AddExpression(
                    new MultExpression(new NumberExpression("x"), new NumberExpression("m")), new NumberExpression("y")
                ),
                new DivExpression(new NumberExpression("z"), new NumberExpression("d"))

            );

            var result = expression.Interpret(context);
            Console.WriteLine("m*x + y - z/d  result: {0}", result);



            //check iterator
            var fm = new FileManager();
            var dir = new Directory();
            fm.SeeFiles(dir);




            //check mediator
            Manager mediator = new Manager();
            Colleague customer = new Customer(mediator);
            Colleague vendor = new Vendor(mediator);
            Colleague woodworker = new Woodworker(mediator);

            mediator.Customer = customer;
            mediator.WoodWorker = woodworker;
            mediator.Vendor = vendor;
            customer.Send("Have an order for a chair");
            woodworker.Send("chair is done");
            vendor.Send("chair ready to sell");



            //check memento
            GameSaver game = new GameSaver();
            Memento.Character myChar = new Memento.Character();
            myChar.Run();
            myChar.CastSpell("dick-bolt");

            Console.WriteLine("you killed a pop-up");
            game.Saves.Push(myChar.SaveState());
            Console.WriteLine("game saved");
            myChar.Run();
            myChar.CastSpell("self-died");

            myChar.RestoreState(game.Saves.Pop());


            //check prototype
            Console.WriteLine("Check Prototype ");
            var eunit = new EarthUnit(100, 50, "mariner", new Prototype.Weapon { Damage = 20, Name = "bolter", Range = 40 }, 100);
            var tmpunit = eunit.Clone();
            Console.WriteLine("Unit 1");
            eunit.GetInfo();
            Console.WriteLine("Unit 2 clone 1");
            tmpunit.GetInfo();

            var funit = new FlightUnit(200, 100, "crusader", new Prototype.Weapon { Damage = 100, Name = "machinegun", Range = 400 }, 200);
            var tmpfunit = funit.Clone();
            Console.WriteLine("Unit 3");
            funit.GetInfo();
            Console.WriteLine("Unit 4 clone 3");
            tmpfunit.GetInfo();



            //check proxy
            using (IContainer container = new ContainerStorageProxy())
            {
                //get 1 product
                Product p1 = container.GetProduct("123ns");
                if (p1 != null)
                    Console.WriteLine(p1.Text);
                //get 2 product
                Product p2 = container.GetProduct("433ns");
                if (p2 != null)
                    Console.WriteLine(p2.Text);

                Product p3 = container.GetProduct("434ns");
                if (p3 != null)
                    Console.WriteLine(p2.Text);
                else
                {
                    Console.WriteLine("There is no 434ns you are looking for");
                }
            }

            //check observer

            Game gameobs = new Game(123);

            Observer.Player player1 = new Observer.Player("player1", gameobs, 23);
            Observer.Player player2 = new Observer.Player("player2", gameobs, 44);

            Guest guest = new Guest("guest1", gameobs);

            // game start
            gameobs.NextMove();

            guest.ExitGame();
            // имитация торгов
            gameobs.NextMove();

            player1.ExitGame();

            Console.Read();

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
            Builder.Sword AdamantitSword = blacksmith.ForgeSword(builder);
            Console.WriteLine(AdamantitSword.ToString());
        }
    }
}
