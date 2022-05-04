using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class ConcreteDefault : AbstractDefault
    {
        string _attribute = "ConcreteDefault ";

        public override string Description
        {
            get { return _attribute; }
        }
    }
}
