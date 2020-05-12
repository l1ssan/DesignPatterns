using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class Guest : IObserver
    {
        public string Name { get; set; }
        IObservable Game;

        public Guest(string name, IObservable game)
        {
            this.Name = name;
            Game = game;
            Game.AddObserver(this);
        }

        public void Update(object state)
        {
            GameInfo gameInfo = (GameInfo)state;
            if (gameInfo.GameStarted)
            {
                Console.WriteLine("Game Started");
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
