using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class CharacteristicTwo : RootAbstract
    {
        public CharacteristicTwo()
        {
            this.Condition = "A condition of this characteristicTwo";
            this.Action = "An action of this characteristicTwo";
        }

        public override void Show(string attribute)
        {
            this.Attribute = attribute;
            Console.WriteLine(Condition + " | " + Action + " | " + Attribute.ToUpper());
            
        }
    }
}
