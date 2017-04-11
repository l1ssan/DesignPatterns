using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class MagicBook
    {
        public void OpenBook()
        {
            Console.WriteLine("open the magic book on page 66");
        }

        public void CastMagicSpell()
        {
            Console.WriteLine("summon Imp lvl 6");
        }

        public void CloseTheMagicBook()
        {
            Console.WriteLine("magic book closed");
        }
    }
}
