using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class Mage
    {
        public void SummonImp(MagicRitualFacade mf)
        {
            mf.StartRitual();
            mf.EndRitual();
        }
    }
}
