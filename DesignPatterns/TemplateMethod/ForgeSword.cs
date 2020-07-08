using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod
{
    public class ForgeSword : Forging
    {
        public override void BilletHeating()
        {
            Console.WriteLine("Heat up the billet");
        }

        public override void BilletForge()
        {
            Console.WriteLine("Forge sword");
        }

        public override void Stabilization()
        {
            Console.WriteLine("Stabilization metal");
        }

        public override void Decoration()
        {
            Console.WriteLine("Decorate sword");
        }


    }
}
