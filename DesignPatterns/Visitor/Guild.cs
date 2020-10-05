using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public class Guild:IAccount
    {
        public string Name { get; set; }
        public string RegId { get; set; }
        public int Power { get; set; }


        public void Accept(IVisitor visitor)
        {
            visitor.VisitGuildAccount(this);
        }

        public void Ban(IVisitor visitor)
        {
            visitor.VisitGuildAccount(this);
        }
    }
}
