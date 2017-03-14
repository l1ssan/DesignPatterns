using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
   public class AdamantitSwordBuilder:SwordBuilder
    {
        public override void SetIronBar()
        {
        }

        public override void SetAdamantitBar()
        {
            this.Sword.AdamantitBar = new Bar() {Type = "Normal"};
        }

        public override void SetSkin()
        {
            this.Sword.Skin = new Skin() {Type = "Dragon Skin"};
        }

        public override void SetAdditives()
        {
            this.Sword.Additives = new Dust() {Name = "Fairy Dust"};

        }
    }
}
