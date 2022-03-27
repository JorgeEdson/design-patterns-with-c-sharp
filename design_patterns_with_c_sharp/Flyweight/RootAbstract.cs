using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public abstract class RootAbstract
    {
        protected string Condition;
        protected string Action;
        public string Attribute { get; set; }

        public abstract void Show(string attribute);
    }
}
