using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class FirstClass : ICommonBehaviors
    {
        public void printSomething()
        {
            Console.WriteLine("You instantiated FirstClass");
        }
    }
}
