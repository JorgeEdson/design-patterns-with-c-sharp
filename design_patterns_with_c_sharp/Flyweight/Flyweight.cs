using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class Flyweight
    {
        private Dictionary<string, RootAbstract> list = 
            new Dictionary<string, RootAbstract>();

        public RootAbstract GetRoot(string attribute) 
        {
            RootAbstract t = null;
            if (list.ContainsKey(attribute))
                t = list[attribute];
            else 
            {
                switch (attribute) 
                {
                    case "One" : t = new CharacteristicOne(); break;
                    case "Two": t = new CharacteristicTwo(); break;
                    case "Three": t = new CharacteristicThree(); break;
                }

                list.Add(attribute, t);
            }

            return t;
        }
    }
}
