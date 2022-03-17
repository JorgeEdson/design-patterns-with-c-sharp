using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class RootFactual : Root
    {
        private string Property1;
        private string Property2;

        public RootFactual(string param1, string param2) 
        {
            Property1 = param1;
            Property2 = param2;
        }

        public override Root Clone()
        {
            Console.WriteLine("This object has the following properties: "+Property1+" and "+ Property2);
            return this.MemberwiseClone() as Root;
            throw new NotImplementedException();
        }



    }
}
