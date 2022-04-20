using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class ConcreteImplementorAttributeOne2 : IAttributeOne
    {
        public IAttributeTwo IAttributeTwo { get; set; }

        public string OperationFromOne()
        {
            return "Implementation 2 AttributeOne with: " + IAttributeTwo.OperationFromTwo();
        }
    }
}
