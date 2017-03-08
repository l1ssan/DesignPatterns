using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public interface IWeapon
    {
       
        void DealDamage(int dmg);
    }
}
