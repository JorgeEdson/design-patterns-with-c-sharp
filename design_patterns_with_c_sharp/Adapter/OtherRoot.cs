using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class OtherRoot
    {
        public void OtherActionOne(string param) 
        {
            Console.WriteLine(param + " performed the OTHER action one");
        }

        public void OtherActionTwo()
        {
            Console.WriteLine("This object performed OTHER action two");
        }
    }
}
