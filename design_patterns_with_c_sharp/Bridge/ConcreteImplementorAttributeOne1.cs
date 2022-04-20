using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class ConcreteImplementorAttributeOne1 : IAttributeOne
    {
        public IAttributeTwo IAttributeTwo { get; set; }

        public string OperationFromOne()
        {
            return "Implementation 1 AttributeOne with: " + IAttributeTwo.OperationFromTwo();
        }
    }
}
