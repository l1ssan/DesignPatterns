using System;

namespace DesignPatterns.Observer
{
   public class Player : IObserver
    {
        public string Name { get; set; }
        IObservable Game;

        public Player(string name, IObservable game, int seedplace)
        {
            this.Name = name;
            Game = game;
            Game.AddObserver(this);
            Random rnd = new Random(seedplace);
            X = rnd.Next(1, 199);
            Y = rnd.Next(1, 199);
        }


        public long XP { get; set; } = 0;
        public int HP { get; set; } = 100;
        public int Damage { get; set; } = 1;

        public int X { get; set; }
        public int Y { get; set; }


        public void Update(object state)
        {
            GameInfo gameInfo = (GameInfo)state;
            if (gameInfo.GameStarted)
            {
                Console.WriteLine("Game next move");


                //move x+1 if it`s free
                if (gameInfo.Map[X + 1, Y] == 0)
                {
                    this.X++;
                    Console.WriteLine($"Player {Name} move to {X} {Y}");
                }
                else if (gameInfo.Map[X, Y + 1] == 0)
                {
                    this.Y++;
                    Console.WriteLine($"Player {Name} move to {X} {Y}");
                }
                else
                {
                    Console.WriteLine($"Player {Name} can`t move");
                }
            }
            else
            {
                Console.WriteLine("Game Stoped");
            }

        }


        public void ExitGame()
        {
            Console.WriteLine($"{Name} exit");
            Game.RemoveObserver(this);
            Game = null;


        }

    }
}
