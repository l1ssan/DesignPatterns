using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Blacksmith
    {
        public Sword ForgeSword(SwordBuilder swordBuilder)
        {
            swordBuilder.CreateSword();
            swordBuilder.SetIronBar();
            swordBuilder.SetAdamantitBar();
            swordBuilder.SetSkin();
            swordBuilder.SetAdditives();
            return swordBuilder.Sword;
        }
    }
}
