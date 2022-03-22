using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Adapter : IAction
    {
        OtherRoot otherRoot;

        public Adapter(OtherRoot otherRoot)
        {
            this.otherRoot = otherRoot;
        }
        
        public void ActionOne(string param)
        {
            this.otherRoot.OtherActionOne(param);
        }

        public void ActionTwo()
        {
            this.otherRoot.OtherActionTwo();
        }
    }
}
