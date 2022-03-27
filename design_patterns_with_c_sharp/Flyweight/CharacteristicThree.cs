using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class CharacteristicThree : RootAbstract
    {
        public CharacteristicThree()
        {
            this.Condition = "A condition of this characteristicThree";
            this.Action = "An action of this characteristicThree";
        }

        public override void Show(string attribute)
        {
            this.Attribute = attribute;
            Console.WriteLine(Condition + " | " + Action + " | " + Attribute.ToUpper());
            
        }
    }
}
