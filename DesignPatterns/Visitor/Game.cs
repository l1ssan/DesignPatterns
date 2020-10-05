using System.Collections.Generic;

namespace DesignPatterns.Visitor
{
   public class Game
    {
        List<IAccount> accounts = new List<IAccount>();
        public void Register(IAccount acc)
        {
            accounts.Add(acc);
        }
        public void Remove(IAccount acc)
        {
            accounts.Remove(acc);
        }
        public void Ban(IAccount acc, IVisitor visitor)
        {
            acc.Ban(visitor);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (IAccount acc in accounts)
                acc.Accept(visitor);
        }
    }
}
