using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    class GameInfo
    {
        public string Name { get; set; }

        public bool GameStarted { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();
        public List<Guest> Guests { get; set; } = new List<Guest>();

        public int[,] Map { get; set; } = new int[200, 200];

        public GameInfo(int seed)
        {
            Name = "Game " + seed;
            int rows = Map.GetUpperBound(0) + 1;
            int columns = Map.Length / rows;
            Random rnd = new Random(seed);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Map[i, j] = rnd.Next(0, 2);
                }
            }
        }
    }
}
