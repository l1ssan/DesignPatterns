using System;
using System.Collections.Generic;

namespace DesignPatterns.Composite
{
    public class Category : Component
    {
        public Category(string name) : base(name)
        {
        }

        public List<Component> MenuItems { get; set; } = new List<Component>();

        public override void Add(Component item)
        {
            MenuItems.Add(item);
        }

        public override void Delete(Component item)
        {
            MenuItems.Remove(item);



        }


        public override Component GetCopy()
        {
            return this;
        }

        public override void Print()
        {
            Console.WriteLine($"Category Name: {Name}");
            foreach (var component in MenuItems)
            {
                Console.WriteLine($"\t {component}");
            }
        }

    }
}
