using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public interface IUnit
    {

        IUnit Clone();
        void GetInfo();


    }
}
