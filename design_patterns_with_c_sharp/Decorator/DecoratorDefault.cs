using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class DecoratorDefault : AbstractDefault
    {
        string _attribute = "DecoratorDeafault ";

        public override string Description
        {
            get { return _attribute; }
        }
    }
}
