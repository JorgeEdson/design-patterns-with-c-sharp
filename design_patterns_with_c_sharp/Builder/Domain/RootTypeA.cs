using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class RootTypeA : Root
    {
        public override void DefineFirstProperty(string param)
        {
            FirstProperty = param;
        }

        public override void DefineSecondProperty(string param)
        {
            SecondProperty = param;
        }

        public override void DefineThirdProperty(bool param)
        {
            ThirdProperty = param;
        }
    }
}
