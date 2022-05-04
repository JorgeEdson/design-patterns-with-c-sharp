using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class ConcreteComponentOne : DecoratorDefault
    {
        string _attribute = "ConcreteComponentOne ";
        AbstractDefault _abstractDefault;

        public ConcreteComponentOne(AbstractDefault abstractDefault)
        {
            _abstractDefault = abstractDefault;
        }

        public override string Description
        {
            get 
            {
                return _abstractDefault.Description + _attribute;
            }
        }
    }
}
