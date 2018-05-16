using System.Collections.Generic;

namespace DesignPatterns.Memento
{
    public class GameSaver
    {
        public Stack<CharMemento> Saves { get; private set; }
        public GameSaver()
        {
            Saves = new Stack<CharMemento>();

        }

      

    }
}
