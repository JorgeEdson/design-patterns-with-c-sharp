using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class FactoryMethod
    {
        public ICommonBehaviors Choose(string option) 
        {
            switch (option) 
            {
                case "1": return new FirstClass();
                case "2": return new SecondClass();
                case "3": return new ThirdClass();
                default: return null;
            }        
        }
    }
}
