using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public class ExportStatVisitor : IVisitor
    {
        public void VisitGuildAccount(Guild acc)
        {
            Console.WriteLine($"Name: {acc.Name}; Power: {acc.Power}; RegId: {acc.RegId};");
        }

        public void VisitPlayerAcccount(Player acc)
        {
            Console.WriteLine($"Name: {acc.Name}; Strength: {acc.Strength}; RegId: {acc.RegId};");
        }
    }
}
