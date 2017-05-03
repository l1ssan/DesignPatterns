using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight
{

 
public class ConstructionFactory
{
    readonly Dictionary<string, Construction> _constructions = new Dictionary<string, Construction>();
        public ConstructionFactory()
        {
            _constructions.Add("WarMachineFactory", new WarMachineFactory());
            _constructions.Add("Warehouse", new Warehouse());
        }

        public Construction GetConstruction(string name)
        {
            return _constructions.ContainsKey(name) ? _constructions[name] : null;
        }
}
}
