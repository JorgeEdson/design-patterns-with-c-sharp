using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class ConcreteComponent : AbstractComponent
    {
        public ConcreteComponent(string name) : base(name) 
        { 
        
        }
        
        
        public override void Add(AbstractComponent component)
        {
            Console.WriteLine("It is not possible to add a new component here.");
        }

        public override void Remove(AbstractComponent component)
        {
            Console.WriteLine("Unable to remove a new component here.");
        }

        public override void Show(int x)
        {
            Console.WriteLine(new string('-', x) + name);
        }
    }
}
