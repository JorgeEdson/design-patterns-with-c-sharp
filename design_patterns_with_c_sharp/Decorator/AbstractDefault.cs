using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class AbstractDefault
    {
        private string _attribute = "AbstractDefault ";

        public virtual string Description
        {
            get { return _attribute; }
        }
    }
}
