using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class GoodIronSwordBuilder : SwordBuilder
    {
        public override void SetIronBar()
        {
            this.Sword.IronBar = new Bar { Type = "Good" };
        }

        public override void SetAdamantitBar()
        {
        }

        public override void SetSkin()
        {
            this.Sword.Skin = new Skin() {Type = "Woolf Skin"};
        }

        public override void SetAdditives()
        {
            this.Sword.Additives = new Dust() {Name = "Diamond Dust"};
        }
    }
}
