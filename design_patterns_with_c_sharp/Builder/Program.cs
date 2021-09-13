using Builder.Factorys;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new Builder();
            AbstractFactoryRoot factoryRoot;
            Root root;

            //Building a root of type A
            factoryRoot = new FactoryRootTypeA();
            builder.BuildRoot(factoryRoot);
            root = factoryRoot.GetRoot();
            root.ShowProperties();

            Console.WriteLine("");

            //Building a root of type B
            factoryRoot = new FactoryRootTypeB();
            builder.BuildRoot(factoryRoot);
            root = factoryRoot.GetRoot();
            root.ShowProperties();

        }
    }
}
