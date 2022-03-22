using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Root root = new Root();
            OtherRoot otherRoot = new OtherRoot();

            IAction adapter = new Adapter(otherRoot);

            root.ActionOne("Some parameter");
            root.ActionTwo();

            Console.WriteLine();

            adapter.ActionOne("Some parameter");
            adapter.ActionTwo();

            Console.ReadKey();
        }
    }
}