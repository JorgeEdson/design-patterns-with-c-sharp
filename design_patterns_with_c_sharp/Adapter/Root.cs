using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Root : IAction
    {
        public void ActionOne(string param)
        {
            Console.WriteLine(param + " performed the action one");
        }

        public void ActionTwo()
        {
            Console.WriteLine("Root performed action two");
        }
    }
}
