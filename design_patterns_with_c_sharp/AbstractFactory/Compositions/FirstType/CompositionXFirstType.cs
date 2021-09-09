using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class CompositionXFirstType : ICompositionX
    {
        public void ToCompose()
        {
            Console.WriteLine("This is composition X of the First Type");
        }
    }
}
