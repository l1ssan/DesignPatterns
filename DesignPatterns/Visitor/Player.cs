using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public class Player : IAccount
    {
        public string Name { get; set; }
        public string RegId { get; set; }

        public int Strength { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitPlayerAcccount(this);
        }

        public void Ban(IVisitor visitor)
        {
            visitor.VisitPlayerAcccount(this);
        }
    }
}
