using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public abstract class SwordBuilder
    {
        public Sword Sword { get; private set; }
        public void CreateSword()
        {
            Sword = new Sword();
        }
        public abstract void SetIronBar();
        public abstract void SetAdamantitBar();
        public abstract void SetSkin();
        public abstract void SetAdditives();
    }
}
