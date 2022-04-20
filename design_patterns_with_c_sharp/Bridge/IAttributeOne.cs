using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public interface IAttributeOne
    {
        string OperationFromOne();
        IAttributeTwo IAttributeTwo { get; set; }
    }
}
