using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public abstract class AbstractComponent
    {

        protected string name;

        public AbstractComponent(string name)
        {
            this.name = name;
        }

        public abstract void Add(AbstractComponent component);
        public abstract void Remove(AbstractComponent component);
        public abstract void Show(int x);

    }
}
