using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class CompositionYSecondType : ICompositionY
    {
        public void ToCompose()
        {
            Console.WriteLine("This is composition Y of the Second Type");
        }
    }
}
