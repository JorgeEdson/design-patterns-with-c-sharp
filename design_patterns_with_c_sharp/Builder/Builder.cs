using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Builder
    {
        public void BuildRoot(AbstractFactoryRoot abstractFactoryRoot) 
        {
            abstractFactoryRoot.FirstProperty();
            abstractFactoryRoot.SecondProperty();
            abstractFactoryRoot.ThirdProperty();
        } 
    }
}
