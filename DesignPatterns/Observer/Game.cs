using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class Game : IObservable
    {
        GameInfo gameInfo;


        List<IObserver> observers;


        public Game(int seed)
        {
            observers = new List<IObserver>();
            gameInfo = new GameInfo(seed);

        }
        //add players or guest
        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(gameInfo);
            }
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NextMove()
        {
            //start game 
            if(!gameInfo.GameStarted)
            {
                gameInfo.GameStarted = true;
                Console.WriteLine("Game Started");
            }
            else
            {
                //gamestate change (Maps change or monster spawn)
            }


            NotifyObservers();
        }

    }
}
