using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class FactoryRootTypeA : AbstractFactoryRoot
    {
        public FactoryRootTypeA()
        {
            _root = new RootTypeA();
        }

        public override void FirstProperty()
        {
            _root.DefineFirstProperty("FirstPropertyTypeA");
        }

        public override void SecondProperty()
        {
            _root.DefineSecondProperty("SecondPropertyTypeA");
        }

        public override void ThirdProperty()
        {
            _root.DefineThirdProperty(true);
        }
    }
}
