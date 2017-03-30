using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public abstract class Component
    {
        protected Component(string name)
        {
            Name = name;
        }

        protected string Name { get; set; }


        public virtual Component GetCopy()
        {
            return this;
        }

        public virtual void Delete(Component item) { }

        public virtual void Add(Component item) { }

        public virtual void Print()
        {
            Console.WriteLine($"Component name: {Name}");
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
