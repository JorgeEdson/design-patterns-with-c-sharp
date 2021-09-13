using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Factorys
{
    public class FactoryRootTypeB : AbstractFactoryRoot
    {
        public FactoryRootTypeB()
        {
            _root = new RootTypeB();
        }

        public override void FirstProperty()
        {
            _root.DefineFirstProperty("FirstPropertyTypeB");
        }

        public override void SecondProperty()
        {
            _root.DefineSecondProperty("SecondPropertyTypeB");
        }

        public override void ThirdProperty()
        {
            _root.DefineThirdProperty(false);
        }
    }
}
