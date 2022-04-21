using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Composite : AbstractComponent
    {
        private List<AbstractComponent> listConponents = new List<AbstractComponent>();

        public Composite(string name): base(name)
        {
                
        }
        
        
        
        public override void Add(AbstractComponent component)
        {
            this.listConponents.Add(component);
        }

        public override void Remove(AbstractComponent component)
        {
            this.listConponents.Remove(component);
        }

        public override void Show(int x)
        {
            Console.WriteLine(new string('-', x) + name);
            foreach (AbstractComponent item in this.listConponents) 
            {
                item.Show(x + 2);
            }
        }
    }
}
