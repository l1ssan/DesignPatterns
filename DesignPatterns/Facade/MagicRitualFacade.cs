using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class MagicRitualFacade
    {
        private MagicBook mbook;
        private MagicTable mtable;
        private ReagentsCreator rcreator;

        public MagicRitualFacade( MagicBook mb, MagicTable mt, ReagentsCreator rc)
        {
            mbook = mb;
            mtable = mt;
            rcreator = rc;
        }


        public void StartRitual()
        {
            rcreator.AddElements();
            rcreator.BlendElements();
            
            mtable.DeployMagicElements();

            mbook.OpenBook();
            mbook.CastMagicSpell();
        }

        public void EndRitual()
        {
            mbook.CloseTheMagicBook();
        }
    }
}
