using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class CompositionZFirstType : ICompositionZ
    {
        public void ToCompose()
        {
            Console.WriteLine("This is composition Z of the First Type");
        }
    }
}
