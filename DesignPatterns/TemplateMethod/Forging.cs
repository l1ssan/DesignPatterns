using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod
{
    public abstract class Forging
    {
        public void Forge()
        {
            BilletHeating();
            BilletForge();
            Stabilization();
            Harden();
            Decoration();
        }


        public abstract void BilletHeating();
        public abstract void BilletForge();
        public abstract void Stabilization();
        public virtual void Harden()
        {
            Console.WriteLine("do not harden");
        }
        public abstract void Decoration();


    }
}
