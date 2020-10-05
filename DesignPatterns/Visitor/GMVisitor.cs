using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public class GMVisitor : IVisitor
    {
        public void VisitGuildAccount(Guild acc)
        {
            if (acc.Power > 100) { Console.WriteLine($"Ban guild name: {acc.Name} cuz power>100"); }
        }

        public void VisitPlayerAcccount(Player acc)
        {
            if (acc.Strength > 100) { Console.WriteLine($"Ban player name: {acc.Name} cuz strength>100"); }
        }
    }
}
