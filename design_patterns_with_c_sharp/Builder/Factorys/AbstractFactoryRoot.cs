using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public abstract class AbstractFactoryRoot
    {
        protected Root _root;

        public Root GetRoot() 
        {
            return _root;
        }

        public abstract void FirstProperty();
        public abstract void SecondProperty();
        public abstract void ThirdProperty();
    }
}
