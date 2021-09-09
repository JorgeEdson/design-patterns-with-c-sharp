using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class CompositionXSecondType : ICompositionX
    {
        public void ToCompose()
        {
            Console.WriteLine("This is composition X of the Second Type");
        }
    }
}
