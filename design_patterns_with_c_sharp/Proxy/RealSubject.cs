using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class RealSubject
    {
        public string Action() 
        {
            return "Action from the real Subject";
        }
    }
}
