using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public interface IAction
    {
        void ActionOne(string param);
        void ActionTwo();
    }
}
