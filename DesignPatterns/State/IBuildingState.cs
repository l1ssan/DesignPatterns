using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public interface IBuildingState
    {
        void Build(House house);
        void Repair(House house);
        void Damage(House house);
        void Destroy(House house);

    }
}
