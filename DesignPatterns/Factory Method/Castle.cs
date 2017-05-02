using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory_Method
{
   public abstract class Castle
    { }

    public class StoneCastle : Castle
    {
        public StoneCastle()
        {
            Console.WriteLine("The Stone Castle was built");
        }
    }
   public class WoodCastle : Castle
    {
        public WoodCastle()
        {
            Console.WriteLine("The Wood Castle was built");
        }
    }
}
