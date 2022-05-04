using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Instantiating default object");
            AbstractDefault objDefault = new ConcreteDefault();
            Console.WriteLine(objDefault.Description.TrimEnd(' ',','));
            Console.WriteLine();
            Console.WriteLine("Including new behaviors");
            objDefault = new ConcreteComponentOne(objDefault);
            objDefault = new ConcreteComponentTwo(objDefault);
            Console.WriteLine(objDefault.Description.TrimEnd(' ', ','));
            Console.ReadKey();
        }
    }
}
