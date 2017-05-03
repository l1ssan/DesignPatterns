using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight
{
    public abstract class Construction
    {
        protected double Square; 
        public abstract void Build(double x, double y);
    }


    public class WarMachineFactory : Construction
    {
        public WarMachineFactory()
        {
           Square = 100;
        }

        public override void Build(double x, double y)
        {
            Console.WriteLine($"WarMachine factory was built in {x} {y}");
        }
    }
    public class Warehouse : Construction
    {
        public Warehouse()
        {
            Square = 200;
        }

        public override void Build(double x, double y)
        {
            Console.WriteLine($"Warehouse was built in {x} {y}");
        }
    }



}
