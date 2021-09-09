using AbstractFactory.Factorys;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactoryTypes factory;
            Console.WriteLine("Choose one of the types to be created: 1 - First Type | 2 - Second Type");
            switch (Console.ReadLine()) 
            {
                case "1": 
                    factory = new FactoryFirstType();
                    break;
                case "2":
                    factory = new FactorySecondType();
                    break;
            }
        }
    }
}
