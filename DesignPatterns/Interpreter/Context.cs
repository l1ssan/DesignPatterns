using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter
{
    public class Context
    {
        private readonly Dictionary<string, double> variables;
        public Context()
        {
            variables = new Dictionary<string, double>();
        }
        // get var value by name
        public double GetVariable(string name)
        {
            return variables[name];
        }

        public void SetVariable(string name, double value)
        {
            if (variables.ContainsKey(name))
                variables[name] = value;
            else
                variables.Add(name, value);
        }
    }
}
