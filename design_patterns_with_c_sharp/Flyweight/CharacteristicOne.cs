using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class CharacteristicOne : RootAbstract
    {
        public CharacteristicOne()
        {
            this.Condition = "A condition of this characteristicOne";
            this.Action = "An action of this characteristicOne";
        }
        
        public override void Show(string attribute)
        {
            this.Attribute = attribute;
            Console.WriteLine(Condition+" | "+Action+" | "+Attribute.ToUpper());
            
        }
    }
}
