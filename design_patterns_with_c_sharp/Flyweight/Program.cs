using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Flyweight flyweight = new Flyweight();
            string attribute = string.Empty;
            RootAbstract rootAbstract;
            
            while (true)
            {
                Console.WriteLine();
                Console.Write("Which of the 3 characteristics " +
                    "do you want to send to the console? ");
                attribute = Console.ReadLine();
                rootAbstract = flyweight.GetRoot(attribute);
                rootAbstract.Show(attribute);
                Console.WriteLine();
                Console.WriteLine("------------------------");
            }
        }
    }
}
