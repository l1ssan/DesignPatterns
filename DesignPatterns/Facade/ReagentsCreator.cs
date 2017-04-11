using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
   public class ReagentsCreator
    {
       public void AddElements()
       {
           Console.WriteLine("Add Additional elements");
       }


       public void BlendElements()
       {
           Console.WriteLine("Blending  elements");
       }
    }
}
