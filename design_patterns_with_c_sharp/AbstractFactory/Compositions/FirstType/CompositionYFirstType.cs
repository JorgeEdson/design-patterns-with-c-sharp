using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class CompositionYFirstType : ICompositionY
    {
        public void ToCompose()
        {
            Console.WriteLine("This is composition Y of the First Type");
        }
    }
}
