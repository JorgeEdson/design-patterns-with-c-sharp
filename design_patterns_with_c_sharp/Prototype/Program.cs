using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            RootManager rootManager = new RootManager();

            rootManager["Default"] = new RootFactual("1º First (default)", "2º Second (default)");
            rootManager["Custom"] = new RootFactual("1º First (custom)", "2º Second (custom)");

            RootFactual obj1 = rootManager["Default"].Clone() as RootFactual;
            RootFactual obj2 = rootManager["Default"].Clone() as RootFactual;
            RootFactual obj3 = rootManager["Custom"].Clone() as RootFactual;

            Console.ReadKey();
        }
    }
}
