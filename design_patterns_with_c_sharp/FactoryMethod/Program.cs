using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod factory = new FactoryMethod();
            Console.WriteLine("Choose which Class you want to instantiate: ");
            Console.WriteLine();
            Console.WriteLine("1 - First Class | 2 - Second Class | 3 - Third Class");            
            string option = Console.ReadLine();

            ICommonBehaviors objResult = factory.Choose(option);

            Console.WriteLine();
            Console.Write("The chosen class was: ");
            objResult.printSomething();
        }
    }
}
