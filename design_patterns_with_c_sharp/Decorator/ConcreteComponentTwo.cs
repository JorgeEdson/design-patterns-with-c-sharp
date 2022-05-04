using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class ConcreteComponentTwo : DecoratorDefault
    {
        string _attribute = "ConcreteComponentTwo ";
        AbstractDefault _abstractDefault;

        public ConcreteComponentTwo(AbstractDefault abstractDefault)
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
