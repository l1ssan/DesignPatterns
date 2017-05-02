using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory_Method
{

    public abstract class Developer
    {
        // fabric method
        abstract public Castle Create();

        public string Name { get; set; }

        protected Developer(string n)
        {
            Name = n;
        }

    }

    public class WoodDeveloper : Developer
    {
        public WoodDeveloper(string n) : base(n)
        {
            Console.WriteLine(n);
        }

        public override Castle Create()
        {
            return new WoodCastle();
        }
    }

    public class StoneDeveloper : Developer
    {
        public StoneDeveloper(string n) : base(n)
        {
            Console.WriteLine(n);
        }

        public override Castle Create()
        {
            return new StoneCastle();
        }
    }

}
