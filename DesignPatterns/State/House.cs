using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class House
    {
        public IBuildingState State { get; set; }
        public House(IBuildingState state)
        {
            State = state;
        }

        public void Build()
        {
            State.Build(this);
        }

        public void Repair()
        {
            State.Repair(this);
        }

        public void Damage()
        {
            State.Damage(this);
        }

    }

}
