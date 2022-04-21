using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite tree = new Composite("Tree");

            Composite twigOne = new Composite("TwigOne");
            twigOne.Add(new ConcreteComponent("LeafOne"));
            twigOne.Add(new ConcreteComponent("LeafTwo"));
            twigOne.Add(new ConcreteComponent("LeafThree"));

            Composite twigTwo = new Composite("TwigTwo");
            twigTwo.Add(new ConcreteComponent("LeafFour"));
            twigTwo.Add(new ConcreteComponent("LeafFive"));

            Composite twigThree = new Composite("TwigThree");
            twigThree.Add(new ConcreteComponent("LeafSix"));


            tree.Add(twigOne);
            tree.Add(twigTwo);
            twigTwo.Add(twigThree);

            tree.Show(1);

            Console.ReadKey();
        }
    }
}
