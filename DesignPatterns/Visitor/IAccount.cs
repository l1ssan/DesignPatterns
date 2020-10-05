using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public interface IAccount
    {
        void Accept(IVisitor visitor);

        void Ban(IVisitor visitor);
    }
}
