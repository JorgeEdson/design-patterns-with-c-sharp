using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public abstract class Root
    {
        public string FirstProperty { get; protected set; }
        public string SecondProperty { get; protected set; }
        public bool ThirdProperty { get; protected set; }

        public abstract void DefineFirstProperty(string param);
        public abstract void DefineSecondProperty(string param);
        public abstract void DefineThirdProperty(bool param);

        public void ShowProperties() 
        {
            Console.WriteLine("This root has the following properties:");
            Console.WriteLine("Type   -> " + GetType());
            Console.WriteLine("First  -> " + FirstProperty);
            Console.WriteLine("Second -> " + SecondProperty);
            Console.WriteLine("Third  -> " + ThirdProperty);
        }
    }
}
